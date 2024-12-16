using System;

namespace DotNetFramework
{
    // File System Operations
    using System.IO;
    public class FileExample {
        private readonly FileStream _file;
        public void ProcessFile() {
            _file = File.Open("test.txt", FileMode.Create);
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello World");
            _file.Write(data, 0, data.Length);
            _file.Close();
        }
    }

    // XML Processing
    using System.Xml;
    public class XmlExample {
        private readonly XmlDocument _doc;
        public void ManageXml() {
            _doc = new XmlDocument();
            XmlElement root = _doc.CreateElement("root");
            root.SetAttribute("id", "1");
            _doc.AppendChild(root);
            _doc.Save("data.xml");
        }
    }

    // Network Communication
    using System.Net;
    public class NetworkExample {
        private readonly WebClient _client;
        public void MakeRequest() {
            _client = new WebClient();
            string data = _client.DownloadString("http://api.example.com");
            _client.UploadString("http://api.example.com", "POST", "data");
        }
    }

    // Threading
    using System.Threading;
    public class ThreadingExample {
        private readonly Thread _worker;
        public void RunThread() {
            _worker = new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Worker completed");
            });
            _worker.Start();
        }
    }

    // Collections
    using System.Collections.Concurrent;
    public class CollectionExample {
        private readonly ConcurrentDictionary<string, int> _dict;
        public void ManageCollection() {
            _dict = new ConcurrentDictionary<string, int>();
            _dict.TryAdd("key1", 100);
            _dict.AddOrUpdate("key2", 1, (key, old) => old + 1);
        }
    }

    // Reflection
    using System.Reflection;
    public class ReflectionExample {
        private readonly Assembly _assembly;
        public void InspectAssembly() {
            _assembly = Assembly.GetExecutingAssembly();
            Type[] types = _assembly.GetTypes();
            foreach(Type t in types) {
                Console.WriteLine(t.Name);
            }
        }
    }

    // Serialization
    using System.Runtime.Serialization;
    public class SerializationExample {
        private readonly DataContractSerializer _serializer;
        public void Serialize() {
            _serializer = new DataContractSerializer(typeof(Person));
            using(FileStream fs = new FileStream("person.xml", FileMode.Create)) {
                _serializer.WriteObject(fs, new Person());
            }
        }
    }

    // Security
    using System.Security.Cryptography;
    public class SecurityExample {
        private readonly RSACryptoServiceProvider _rsa;
        public void Encrypt() {
            _rsa = new RSACryptoServiceProvider();
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Secret data");
            byte[] encrypted = _rsa.Encrypt(data, false);
        }
    }

    // Configuration
    using System.Configuration;
    public class ConfigExample {
        private readonly Configuration _config;
        public void ManageConfig() {
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings.Add("key", "value");
            _config.Save();
        }
    }

    // Drawing
    using System.Drawing;
    public class DrawingExample {
        private readonly Bitmap _bitmap;
        public void CreateImage() {
            _bitmap = new Bitmap(800, 600);
            using(Graphics g = Graphics.FromImage(_bitmap)) {
                g.DrawRectangle(Pens.Black, 0, 0, 100, 100);
            }
        }
    }

    // Windows Forms
    using System.Windows.Forms;
    public class WinFormsExample {
        private readonly Form _form;
        public void ShowForm() {
            _form = new Form();
            _form.Text = "Example Form";
            _form.Width = 400;
            _form.Height = 300;
            _form.Show();
        }
    }

    // Regular Expressions
    using System.Text.RegularExpressions;
    public class RegexExample {
        private readonly Regex _regex;
        public void ValidateText() {
            _regex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
            bool isValid = _regex.IsMatch("test@email.com");
        }
    }

    // Diagnostics
    using System.Diagnostics;
    public class DiagnosticsExample {
        private readonly EventLog _log;
        public void WriteLog() {
            _log = new EventLog("Application");
            _log.Source = "MyApplication";
            _log.WriteEntry("Application started", EventLogEntryType.Information);
        }
    }

    // Transactions
    using System.Transactions;
    public class TransactionExample {
        private readonly TransactionScope _scope;
        public void ExecuteTransaction() {
            _scope = new TransactionScope();
            // Perform transactional operations
            _scope.Complete();
        }
    }

    // Data Access
    using System.Data.SqlClient;
    public class SqlExample {
        private readonly SqlConnection _connection;
        public void QueryDatabase() {
            _connection = new SqlConnection("connection_string");
            _connection.Open();
            using(SqlCommand cmd = new SqlCommand("SELECT * FROM Users", _connection)) {
                SqlDataReader reader = cmd.ExecuteReader();
            }
        }
    }
}
}