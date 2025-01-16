using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Diagnostics;
using Oracle.DataAccess.Connection;
using Oracle.DataAccess.Transaction;
using Oracle.DataAccess.Command;
using Oracle.DataAccess.Parameter;
using Oracle.DataAccess.DataReader;
using Oracle.DataAccess.DataAdapter;
using Oracle.DataAccess.Bulk;
using Oracle.DataAccess.Metadata;
using Oracle.DataAccess.Notification;
using Oracle.DataAccess.HA;
using Oracle.DataAccess.Security;
using Oracle.DataAccess.Logging;
using Oracle.DataAccess.Caching;
using Oracle.DataAccess.Failover;
using Oracle.DataAccess.Performance;
using Oracle.DataAccess.Monitoring;
using Oracle.DataAccess.Configuration;

namespace OracleDataAccess
{
    // Oracle.DataAccess.Client Example
    public class ClientExample
    {
        private OracleConnection connection;

        public void CreateConnection()
        {
            connection = new OracleConnection("Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;");
            connection.Open();
        }
    }

    // Oracle.DataAccess.Types Example
    public class TypesExample
    {
        private OracleDecimal oracleDecimal;

        public void HandleOracleTypes()
        {
            oracleDecimal = new OracleDecimal(1234.56);
            decimal regularDecimal = oracleDecimal.Value;
        }
    }

    // Oracle.DataAccess.Diagnostics Example
    public class DiagnosticsExample
    {
        private OracleTraceLevel traceLevel;

        public void ConfigureDiagnostics()
        {
            traceLevel = OracleTraceLevel.All;
            OracleTrace.TraceLevel = traceLevel;
        }
    }

    // Oracle.DataAccess.Connection Example
    public class ConnectionExample
    {
        private OracleConnectionStringBuilder builder;

        public void BuildConnectionString()
        {
            builder = new OracleConnectionStringBuilder();
            builder.DataSource = "MyOracleDB";
            builder.UserID = "myUsername";
        }
    }

    // Oracle.DataAccess.Transaction Example
    public class TransactionExample
    {
        private OracleTransaction transaction;

        public void ManageTransaction(OracleConnection conn)
        {
            transaction = conn.BeginTransaction();
            transaction.Commit();
        }
    }

    // Oracle.DataAccess.Command Example
    public class CommandExample
    {
        private OracleCommand command;

        public void ExecuteCommand()
        {
            command = new OracleCommand();
            command.CommandText = "SELECT * FROM Employees";
        }
    }

    // Oracle.DataAccess.Parameter Example
    public class ParameterExample
    {
        private OracleParameter parameter;

        public void ConfigureParameter()
        {
            parameter = new OracleParameter();
            parameter.ParameterName = "EmpId";
            parameter.Value = 1001;
        }
    }

    // Oracle.DataAccess.DataReader Example
    public class DataReaderExample
    {
        private OracleDataReader reader;

        public void ReadData(OracleCommand cmd)
        {
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Process data
            }
        }
    }

    // Oracle.DataAccess.DataAdapter Example
    public class DataAdapterExample
    {
        private OracleDataAdapter adapter;

        public void UseDataAdapter()
        {
            adapter = new OracleDataAdapter();
            adapter.SelectCommand = new OracleCommand("SELECT * FROM Products");
        }
    }

    // Oracle.DataAccess.Bulk Example
    public class BulkExample
    {
        private OracleBulkCopy bulkCopy;

        public void PerformBulkCopy(OracleConnection conn)
        {
            bulkCopy = new OracleBulkCopy(conn);
            bulkCopy.DestinationTableName = "BulkData";
        }
    }

    // Oracle.DataAccess.Metadata Example
    public class MetadataExample
    {
        private OracleSchemaReader schemaReader;

        public void ReadSchema(OracleConnection conn)
        {
            schemaReader = new OracleSchemaReader(conn);
            schemaReader.GetTables();
        }
    }

    // Oracle.DataAccess.Notification Example
    public class NotificationExample
    {
        private OracleNotificationRequest notification;

        public void SetupNotification()
        {
            notification = new OracleNotificationRequest();
            notification.Timeout = 10000;
        }
    }

    // Oracle.DataAccess.HA Example
    public class HAExample
    {
        private OracleHAEventArgs haEventArgs;

        public void HandleHAEvent()
        {
            haEventArgs = new OracleHAEventArgs();
            haEventArgs.Source = "Primary Database";
        }
    }

    // Oracle.DataAccess.Security Example
    public class SecurityExample
    {
        private OracleCredential credential;

        public void SetCredentials()
        {
            credential = new OracleCredential("username", "password");
        }
    }

    // Oracle.DataAccess.Logging Example
    public class LoggingExample
    {
        private OracleLog log;

        public void ConfigureLogging()
        {
            log = new OracleLog();
            log.Level = OracleLogLevel.Detailed;
        }
    }

    // Oracle.DataAccess.Caching Example
    public class CachingExample
    {
        private OracleCache cache;

        public void SetupCache()
        {
            cache = new OracleCache();
            cache.MaxSize = 1000;
        }
    }

    // Oracle.DataAccess.Failover Example
    public class FailoverExample
    {
        private OracleFailoverEventArgs failoverArgs;

        public void HandleFailover()
        {
            failoverArgs = new OracleFailoverEventArgs();
            failoverArgs.FailoverType = FailoverType.Session;
        }
    }

    // Oracle.DataAccess.Performance Example
    public class PerformanceExample
    {
        private OraclePerformanceCounters perfCounters;

        public void MonitorPerformance()
        {
            perfCounters = new OraclePerformanceCounters();
            perfCounters.EnableCollection = true;
        }
    }

    // Oracle.DataAccess.Monitoring Example
    public class MonitoringExample
    {
        private OracleMonitor monitor;

        public void SetupMonitoring()
        {
            monitor = new OracleMonitor();
            monitor.StartMonitoring();
        }
    }

    // Oracle.DataAccess.Configuration Example
    public class ConfigurationExample
    {
        private OracleConfiguration config;

        public void ConfigureSettings()
        {
            config = OracleConfiguration.Default;
            config.CommandTimeout = 30;
        }
    }
}
