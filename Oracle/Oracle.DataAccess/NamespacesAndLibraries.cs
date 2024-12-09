using System;

namespace OracleDataAccess
{
    // Basic database connectivity
    using Oracle.DataAccess.Client;
    public class ConnectionExample {
        private readonly OracleConnection _connection = new OracleConnection();
        public void ConfigureConnection() {
            _connection.ConnectionString = "Data Source=ORCL;User Id=system;Password=password;";
            _connection.Open();
        }
    }

    // Command execution
    using Oracle.DataAccess.CommandBuilder;
    public class CommandExample {
        private readonly OracleCommand _command = new OracleCommand();
        public void ExecuteCommand() {
            _command.CommandText = "SELECT * FROM employees";
            _command.ExecuteNonQuery();
        }
    }

    // Transaction management
    using Oracle.DataAccess.Transaction;
    public class TransactionExample {
        private readonly OracleTransaction _transaction;
        public void ManageTransaction(OracleConnection conn) {
            _transaction = conn.BeginTransaction();
            _transaction.Commit();
        }
    }

    // Data type handling
    using Oracle.DataAccess.Types;
    public class DataTypeExample {
        private readonly OracleDecimal _decimal = new OracleDecimal();
        public void HandleTypes() {
            OracleDate date = OracleDate.GetSysDate();
            OracleString str = new OracleString("Sample");
        }
    }

    // Bulk operations
    using Oracle.DataAccess.Bulk;
    public class BulkOperationsExample {
        private readonly OracleBulkCopy _bulkCopy = new OracleBulkCopy();
        public void PerformBulkCopy() {
            _bulkCopy.DestinationTableName = "target_table";
            _bulkCopy.BatchSize = 1000;
        }
    }

    // XML data handling
    using Oracle.DataAccess.XML;
    public class XmlExample {
        private readonly OracleXmlType _xml = new OracleXmlType();
        public void ProcessXml(OracleConnection conn) {
            _xml.Stream = new System.IO.MemoryStream();
            _xml.Save();
        }
    }

    // LOB handling
    using Oracle.DataAccess.LOB;
    public class LobExample {
        private readonly OracleLob _lob;
        public void ManageLob(OracleConnection conn) {
            OracleClob clob = new OracleClob(conn);
            clob.Write(new byte[] { }, 0, 0);
        }
    }

    // Parameter binding
    using Oracle.DataAccess.Parameters;
    public class ParameterExample {
        private readonly OracleParameter _param = new OracleParameter();
        public void ConfigureParameter() {
            _param.ParameterName = "p_employee_id";
            _param.OracleDbType = OracleDbType.Int32;
        }
    }

    // Database change notification
    using Oracle.DataAccess.Notification;
    public class NotificationExample {
        private readonly OracleChangeNotification _notification = new OracleChangeNotification();
        public void SetupNotification() {
            _notification.RegisterQuery("SELECT * FROM employees");
            _notification.OnChange += (sender, args) => {
                Console.WriteLine("Data changed!");
            };
        }
    }

    // Distributed transactions
    using Oracle.DataAccess.DTC;
    public class DistributedTransactionExample {
        private readonly OracleDistributedTransaction _dtc;
        public void ManageDistributedTx(OracleConnection conn) {
            _dtc = conn.EnlistDistributedTransaction();
            _dtc.Prepare();
        }
    }
}