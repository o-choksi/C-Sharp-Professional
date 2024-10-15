using System;
using System.Collections.Generic;
using System.Configuration;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace OracleDataAccessProject.DAL
{
    public class DataAccess : IDisposable
    {
        private readonly OracleConnection _connection;

        public DataAccess()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OracleDbConnection"].ConnectionString;
            _connection = new OracleConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
                _connection.Close();
        }

        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }

        // Example CRUD operation - Fetch data
        public List<SampleEntity> GetAllEntities()
        {
            var entities = new List<SampleEntity>();
            string query = "SELECT ID, NAME FROM SAMPLE_TABLE";

            using (var command = new OracleCommand(query, _connection))
            {
                OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        entities.Add(new SampleEntity
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                CloseConnection();
            }

            return entities;
        }

        // Insert operation
        public void InsertEntity(SampleEntity entity)
        {
            string query = "INSERT INTO SAMPLE_TABLE (ID, NAME) VALUES (:ID, :NAME)";
            using (var command = new OracleCommand(query, _connection))
            {
                command.Parameters.Add(":ID", entity.Id);
                command.Parameters.Add(":NAME", entity.Name);
                
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        // Update operation
        public void UpdateEntity(SampleEntity entity)
        {
            string query = "UPDATE SAMPLE_TABLE SET NAME = :NAME WHERE ID = :ID";
            using (var command = new OracleCommand(query, _connection))
            {
                command.Parameters.Add(":ID", entity.Id);
                command.Parameters.Add(":NAME", entity.Name);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        // Delete operation
        public void DeleteEntity(int id)
        {
            string query = "DELETE FROM SAMPLE_TABLE WHERE ID = :ID";
            using (var command = new OracleCommand(query, _connection))
            {
                command.Parameters.Add(":ID", id);

                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
