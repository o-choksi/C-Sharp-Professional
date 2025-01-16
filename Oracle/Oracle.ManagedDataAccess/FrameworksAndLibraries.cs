using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.EntityFramework;
using Oracle.ManagedDataAccess.WPF;
using Oracle.ManagedDataAccess.Web;
using Oracle.ManagedDataAccess.Json;
using Oracle.ManagedDataAccess.Xml;
using Oracle.ManagedDataAccess.Diagnostics;
using Oracle.ManagedDataAccess.Logging;
using Oracle.ManagedDataAccess.Security;
using Oracle.ManagedDataAccess.Caching;
using Oracle.ManagedDataAccess.Monitoring;
using Oracle.ManagedDataAccess.Configuration;
using Oracle.ManagedDataAccess.Performance;
using Oracle.ManagedDataAccess.HA;

namespace OracleExamples
{
    // Oracle.ManagedDataAccess.Client Example
    public class ClientExample
    {
        private OracleConnection connection;

        public void CreateConnection()
        {
            connection = new OracleConnection("Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;");
            connection.Open();
        }
    }

    // Oracle.ManagedDataAccess.Types Example
    public class TypesExample
    {
        private OracleDecimal oracleDecimal;

        public void HandleOracleTypes()
        {
            oracleDecimal = new OracleDecimal(1234.56);
            decimal regularDecimal = oracleDecimal.Value;
        }
    }

    // Oracle.ManagedDataAccess.EntityFramework Example
    public class EntityFrameworkExample
    {
        private OracleContext dbContext;

        public void UseEntityFramework()
        {
            dbContext = new OracleContext();
            var query = dbContext.Employees.Where(e => e.Salary > 50000);
        }
    }

    // Oracle.ManagedDataAccess.WPF Example
    public class WPFExample
    {
        private OracleDataProvider dataProvider;

        public void ConfigureWPFBinding()
        {
            dataProvider = new OracleDataProvider();
            dataProvider.ConnectionString = "Data Source=MyOracleDB";
        }
    }

    // Oracle.ManagedDataAccess.Web Example
    public class WebExample
    {
        private OracleWebProvider webProvider;

        public void ConfigureWebAccess()
        {
            webProvider = new OracleWebProvider();
            webProvider.EnablePooling = true;
        }
    }

    // Oracle.ManagedDataAccess.Json Example
    public class JsonExample
    {
        private OracleJsonSerializer serializer;

        public void HandleJson()
        {
            serializer = new OracleJsonSerializer();
            serializer.SerializeObject(new { id = 1, name = "Test" });
        }
    }

    // Oracle.ManagedDataAccess.Xml Example
    public class XmlExample
    {
        private OracleXmlReader xmlReader;

        public void ProcessXml()
        {
            xmlReader = new OracleXmlReader();
            xmlReader.ReadXmlData("SELECT * FROM Employees FOR XML AUTO");
        }
    }

    // Oracle.ManagedDataAccess.Diagnostics Example
    public class DiagnosticsExample
    {
        private OracleTraceSource traceSource;

        public void ConfigureDiagnostics()
        {
            traceSource = new OracleTraceSource();
            traceSource.Switch.Level = SourceLevels.All;
        }
    }

    // Oracle.ManagedDataAccess.Logging Example
    public class LoggingExample
    {
        private OracleLogManager logManager;

        public void ConfigureLogging()
        {
            logManager = new OracleLogManager();
            logManager.EnableFileLogging("oracle_log.txt");
        }
    }

    // Oracle.ManagedDataAccess.Security Example
    public class SecurityExample
    {
        private OracleSecureConnection secureConn;

        public void SetupSecureConnection()
        {
            secureConn = new OracleSecureConnection();
            secureConn.EnableSSL = true;
        }
    }

    // Oracle.ManagedDataAccess.Caching Example
    public class CachingExample
    {
        private OracleResultCache resultCache;

        public void ConfigureCache()
        {
            resultCache = new OracleResultCache();
            resultCache.TimeToLive = TimeSpan.FromMinutes(30);
        }
    }

    // Oracle.ManagedDataAccess.Monitoring Example
    public class MonitoringExample
    {
        private OraclePerformanceMonitor monitor;

        public void SetupMonitoring()
        {
            monitor = new OraclePerformanceMonitor();
            monitor.EnableMetrics(MetricType.All);
        }
    }

    // Oracle.ManagedDataAccess.Configuration Example
    public class ConfigurationExample
    {
        private OracleConfiguration config;

        public void ConfigureSettings()
        {
            config = OracleConfiguration.Default;
            config.BindByName = true;
        }
    }

    // Oracle.ManagedDataAccess.Performance Example
    public class PerformanceExample
    {
        private OraclePerformanceCollector collector;

        public void CollectMetrics()
        {
            collector = new OraclePerformanceCollector();
            collector.StartCollection();
        }
    }

    // Oracle.ManagedDataAccess.HA Example
    public class HAExample
    {
        private OracleHAManager haManager;

        public void ConfigureHA()
        {
            haManager = new OracleHAManager();
            haManager.EnableFailover = true;
        }
    }
}
