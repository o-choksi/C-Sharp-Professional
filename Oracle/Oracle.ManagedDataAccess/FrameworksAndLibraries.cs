using System;

namespace OracleManagedDataAccess
{
    // Basic database connectivity
    using Oracle.ManagedDataAccess.Client;
    public class ConnectionExample {
        private readonly OracleConnection _connection = new OracleConnection();
        public void ConfigureConnection() {
            _connection.ConnectionString = "Data Source=ORCL;User Id=system;Password=password;";
            _connection.Open();
        }
    }

    // Data reader operations
    using Oracle.ManagedDataAccess.Types;
    public class DataReaderExample {
        private readonly OracleCommand _command = new OracleCommand();
        public void ReadData(OracleConnection conn) {
            _command.Connection = conn;
            _command.CommandText = "SELECT * FROM employees";
            using (OracleDataReader reader = _command.ExecuteReader()) {
                while (reader.Read()) {
                    Console.WriteLine(reader["employee_name"].ToString());
                }
            }
        }
    }

    // Parameter binding with array binding
    using Oracle.ManagedDataAccess.Client;
    public class ArrayBindingExample {
        private readonly OracleCommand _command = new OracleCommand();
        public void BindArrayParameters(OracleConnection conn) {
            int[] empIds = { 1, 2, 3, 4, 5 };
            _command.Connection = conn;
            _command.ArrayBindCount = empIds.Length;
            _command.CommandText = "UPDATE employees SET salary = salary + 100 WHERE employee_id = :id";
            _command.Parameters.Add(":id", OracleDbType.Int32).Value = empIds;
            _command.ExecuteNonQuery();
        }
    }

    // Batch operations
    using Oracle.ManagedDataAccess.Client;
    public class BatchProcessingExample {
        private readonly OracleCommand _command = new OracleCommand();
        public void ExecuteBatch(OracleConnection conn) {
            _command.Connection = conn;
            _command.AddToStatementCache = true;
            
            _command.CommandText = "INSERT INTO departments (id, name) VALUES (:1, :2)";
            _command.Parameters.Add(":1", OracleDbType.Int32);
            _command.Parameters.Add(":2", OracleDbType.Varchar2);
            
            for (int i = 1; i <= 100; i++) {
                _command.Parameters[0].Value = i;
                _command.Parameters[1].Value = $"Department {i}";
                _command.ExecuteNonQuery();
            }
        }
    }

    // PL/SQL ref cursor
    using Oracle.ManagedDataAccess.Client;
    public class RefCursorExample {
        private readonly OracleCommand _command = new OracleCommand();
        public void FetchRefCursor(OracleConnection conn) {
            _command.Connection = conn;
            _command.CommandText = "BEGIN OPEN :result_cursor FOR SELECT * FROM employees; END;";
            _command.CommandType = System.Data.CommandType.Text;
            
            OracleParameter resultCursor = new OracleParameter();
            resultCursor.ParameterName = ":result_cursor";
            resultCursor.OracleDbType = OracleDbType.RefCursor;
            resultCursor.Direction = System.Data.ParameterDirection.Output;
            _command.Parameters.Add(resultCursor);
            
            _command.ExecuteNonQuery();
            OracleDataReader reader = ((OracleRefCursor)resultCursor.Value).GetDataReader();
            while (reader.Read()) {
                Console.WriteLine(reader["employee_name"].ToString());
            }
        }
    }
}