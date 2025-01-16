using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Security;
using System.Xml;

namespace ASPNet
{
    // System Examples
    public class SystemExamples
    {
        public void BasicTypes()
        {
            string text = "Hello World";
            int number = 42;
            DateTime now = DateTime.Now;
            bool flag = true;
            decimal money = 99.99m;
            Guid id = Guid.NewGuid();
            TimeSpan duration = TimeSpan.FromHours(1);
            Uri url = new Uri("http://example.com");
            Version version = new Version(1, 0);
            Random random = new Random();
        }
    }

    // System.Data Examples
    public class DataExamples
    {
        public void DataOperations()
        {
            DataSet dataSet = new DataSet("MyDataSet");
            DataTable table = new DataTable("MyTable");
            DataRow row = table.NewRow();
            DataColumn column = new DataColumn("Column1", typeof(string));
            DataView view = new DataView(table);
            DataRelation relation = new DataRelation("Relation1", column, column);
            DataAdapter adapter = new DataAdapter();
            CommandType cmdType = CommandType.StoredProcedure;
            IsolationLevel isolation = IsolationLevel.ReadCommitted;
            ConstraintCollection constraints = table.Constraints;
        }
    }

    // System.Data.SqlClient Examples
    public class SqlClientExamples
    {
        public void DatabaseOperations()
        {
            SqlConnection conn = new SqlConnection("connection_string");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table");
            SqlDataReader reader = null;
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlTransaction trans = null;
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            SqlException sqlEx = null;
            SqlInfoMessageEventArgs msgArgs = null;
        }
    }

    // System.Drawing Examples
    public class DrawingExamples
    {
        public void GraphicsOperations()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 12);
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Red);
            Point point = new Point(10, 10);
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            Image image = Image.FromFile("image.jpg");
            Icon icon = new Icon("icon.ico");
            ColorConverter converter = new ColorConverter();
        }
    }

    // System.IO Examples
    public class IOExamples
    {
        public void FileOperations()
        {
            FileStream fs = File.Create("test.txt");
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            DirectoryInfo dir = new DirectoryInfo("path");
            FileInfo file = new FileInfo("file.txt");
            Path.Combine("path1", "path2");
            BinaryReader binReader = new BinaryReader(fs);
            BinaryWriter binWriter = new BinaryWriter(fs);
            MemoryStream memStream = new MemoryStream();
            BufferedStream buffStream = new BufferedStream(fs);
        }
    }

    // System.Net Examples
    public class NetworkExamples
    {
        public void NetworkOperations()
        {
            WebClient client = new WebClient();
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            NetworkCredential cred = new NetworkCredential("user", "pass");
            WebRequest request = WebRequest.Create("http://example.com");
            WebResponse response = null;
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://example.com");
            IPHostEntry host = Dns.GetHostEntry("localhost");
            Cookie cookie = new Cookie("name", "value");
            SocketAddress addr = new SocketAddress(AddressFamily.InterNetwork);
            NetworkStream netStream = null;
        }
    }

    // System.Text Examples
    public class TextExamples
    {
        public void TextOperations()
        {
            StringBuilder builder = new StringBuilder();
            Encoding utf8 = Encoding.UTF8;
            ASCIIEncoding ascii = new ASCIIEncoding();
            UnicodeEncoding unicode = new UnicodeEncoding();
            UTF32Encoding utf32 = new UTF32Encoding();
            UTF7Encoding utf7 = new UTF7Encoding();
            Decoder decoder = utf8.GetDecoder();
            Encoder encoder = utf8.GetEncoder();
            byte[] bytes = utf8.GetBytes("text");
            char[] chars = new char[10];
        }
    }

    // System.Threading Examples
    public class ThreadingExamples
    {
        public void ThreadOperations()
        {
            Thread thread = new Thread(() => Console.WriteLine("Hello"));
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine("Work"));
            Mutex mutex = new Mutex();
            Semaphore semaphore = new Semaphore(1, 1);
            Monitor.Enter(new object());
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            ManualResetEvent manualEvent = new ManualResetEvent(false);
            ReaderWriterLock rwLock = new ReaderWriterLock();
            Timer timer = new Timer(state => Console.WriteLine("Tick"));
            ThreadLocal<int> local = new ThreadLocal<int>();
        }
    }

    // System.Web Examples
    public class WebBasicExamples
    {
        public void WebOperations(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            HttpServerUtility server = context.Server;
            HttpCookie cookie = new HttpCookie("name", "value");
            HttpApplicationState app = context.Application;
            HttpSessionState session = context.Session;
            HttpBrowserCapabilities browser = request.Browser;
            HttpClientCertificate cert = request.ClientCertificate;
            HttpFileCollection files = request.Files;
            HttpCachePolicy cache = response.Cache;
        }
    }

    // System.Web.Caching Examples
    public class CachingExamples
    {
        public void CacheOperations()
        {
            Cache cache = new Cache();
            CacheDependency dependency = new CacheDependency("path");
            CacheItemPriority priority = CacheItemPriority.Normal;
            AggregateCacheDependency aggDep = new AggregateCacheDependency();
            CacheItemRemovedCallback callback = null;
            CacheItemUpdateCallback updateCallback = null;
            CacheEntry entry = null;
            DateTime expiry = DateTime.Now.AddHours(1);
            TimeSpan slidingExpiration = TimeSpan.FromMinutes(20);
            object cachedItem = cache["key"];
        }
    }

    // System.Web.Configuration Examples
    public class WebConfigExamples
    {
        public void ConfigOperations()
        {
            WebConfigurationManager.AppSettings["key"];
            AuthenticationSection authSection = null;
            AuthorizationSection authzSection = null;
            CustomErrorsSection errorsSection = null;
            SessionStateSection sessionSection = null;
            CompilationSection compSection = null;
            PagesSection pagesSection = null;
            HttpModulesSection modulesSection = null;
            HttpHandlersSection handlersSection = null;
            WebConfigurationManager.ConnectionStrings["connString"];
        }
    }

    // System.Web.Security Examples
    public class SecurityExamples
    {
        public void SecurityOperations()
        {
            FormsAuthentication.SetAuthCookie("user", false);
            MembershipProvider provider = Membership.Provider;
            RoleProvider roleProvider = Roles.Provider;
            MembershipUser user = Membership.GetUser();
            FormsIdentity identity = null;
            FormsAuthenticationTicket ticket = null;
            UrlAuthorizationModule urlAuth = null;
            WindowsAuthenticationModule winAuth = null;
            PassportIdentity passport = null;
            MachineKeySection machineKey = null;
        }
    }

    // System.Xml Examples
    public class XmlExamples
    {
        public void XmlOperations()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode node = doc.CreateElement("element");
            XmlAttribute attr = doc.CreateAttribute("name");
            XmlReader reader = XmlReader.Create("file.xml");
            XmlWriter writer = XmlWriter.Create("output.xml");
            XmlNavigator navigator = null;
            XmlNodeList nodeList = doc.SelectNodes("//path");
            XmlNamespaceManager nsManager = new XmlNamespaceManager(new NameTable());
            XmlSchema schema = new XmlSchema();
            XmlValidatingReader validatingReader = null;
        }
    }
}