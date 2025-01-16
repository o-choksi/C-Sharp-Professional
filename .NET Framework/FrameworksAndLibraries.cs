using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace NETFramework
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

    // System.Collections.Generic Examples
    public class CollectionsExamples
    {
        public void CollectionTypes()
        {
            List<string> list = new List<string>();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            Queue<int> queue = new Queue<int>();
            Stack<double> stack = new Stack<double>();
            HashSet<string> set = new HashSet<string>();
            LinkedList<int> linked = new LinkedList<int>();
            SortedList<string, int> sorted = new SortedList<string, int>();
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
            SortedSet<int> sortedSet = new SortedSet<int>();
            KeyValuePair<string, int> pair = new KeyValuePair<string, int>("key", 1);
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

    // System.Diagnostics Examples
    public class DiagnosticsExamples
    {
        public void DiagnosticOperations()
        {
            Process process = Process.GetCurrentProcess();
            EventLog eventLog = new EventLog("Application");
            PerformanceCounter perfCounter = new PerformanceCounter();
            ProcessStartInfo startInfo = new ProcessStartInfo("notepad.exe");
            Debug.WriteLine("Debug message");
            Trace.WriteLine("Trace message");
            StackTrace stackTrace = new StackTrace();
            ProcessThread thread = process.Threads[0];
            ProcessModuleCollection modules = process.Modules;
            ProcessThreadCollection threads = process.Threads;
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

    // System.Management Examples
    public class ManagementExamples
    {
        public void ManagementOperations()
        {
            ManagementObject mgmtObj = new ManagementObject();
            ManagementClass mgmtClass = new ManagementClass();
            ManagementPath path = new ManagementPath();
            ManagementScope scope = new ManagementScope();
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_Process");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementBaseObject baseObj = null;
            ManagementEventWatcher watcher = new ManagementEventWatcher();
            ManagementOperationObserver observer = new ManagementOperationObserver();
            WqlEventQuery eventQuery = new WqlEventQuery();
        }
    }

    // System.Media Examples
    public class MediaExamples
    {
        public void MediaOperations()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "sound.wav";
            SystemSounds.Asterisk.Play();
            SystemSounds.Beep.Play();
            SystemSounds.Exclamation.Play();
            SystemSounds.Hand.Play();
            SystemSounds.Question.Play();
            player.LoadAsync();
            player.PlaySync();
            player.Stop();
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

    // System.Net.Mail Examples
    public class MailExamples
    {
        public void MailOperations()
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress("from@example.com");
            MailAddress to = new MailAddress("to@example.com");
            Attachment attachment = new Attachment("file.txt");
            AlternateView view = AlternateView.CreateAlternateViewFromString("content");
            LinkedResource resource = new LinkedResource("image.jpg");
            MailPriority priority = MailPriority.Normal;
            message.Subject = "Test";
            message.Body = "Content";
        }
    }

    // System.Reflection Examples
    public class ReflectionExamples
    {
        public void ReflectionOperations()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = typeof(string);
            MethodInfo method = type.GetMethod("ToString");
            PropertyInfo property = type.GetProperty("Length");
            FieldInfo field = type.GetField("Empty");
            ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);
            Module module = assembly.GetModule("module");
            ParameterInfo param = method.GetParameters()[0];
            MemberInfo member = type.GetMember("Length")[0];
            EventInfo eventInfo = type.GetEvent("EventName");
        }
    }

    // System.Runtime.InteropServices Examples
    public class InteropExamples
    {
        public void InteropOperations()
        {
            GCHandle handle = GCHandle.Alloc(new object());
            Marshal.AllocHGlobal(100);
            ComImportAttribute comImport = new ComImportAttribute();
            DllImportAttribute dllImport = new DllImportAttribute("kernel32.dll");
            StructLayoutAttribute structLayout = new StructLayoutAttribute(LayoutKind.Sequential);
            SafeHandle safeHandle = null;
            HandleRef handleRef = new HandleRef();
            COMException comEx = null;
            UnmanagedType unmanagedType = UnmanagedType.Bool;
            IntPtr ptr = IntPtr.Zero;
        }
    }

    // System.Security.Cryptography Examples
    public class CryptoExamples
    {
        public void CryptoOperations()
        {
            MD5 md5 = MD5.Create();
            SHA256 sha256 = SHA256.Create();
            RSA rsa = RSA.Create();
            AES aes = AES.Create();
            HMAC hmac = HMAC.Create();
            TripleDES des3 = TripleDES.Create();
            DSA dsa = DSA.Create();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            CryptoStream cryptoStream = null;
            HashAlgorithm hash = SHA1.Create();
        }
    }

    // System.ServiceProcess Examples
    public class ServiceExamples
    {
        public void ServiceOperations()
        {
            ServiceController controller = new ServiceController("Service");
            ServiceControllerStatus status = ServiceControllerStatus.Running;
            ServiceType serviceType = ServiceType.Win32OwnProcess;
            ServiceStartMode startMode = ServiceStartMode.Automatic;
            TimeSpan timeout = TimeSpan.FromSeconds(30);
            controller.Start();
            controller.Stop();
            controller.Pause();
            controller.Continue();
            controller.WaitForStatus(ServiceControllerStatus.Running);
        }
    }

    // System.Speech.Synthesis Examples
    public class SpeechExamples
    {
        public void SpeechOperations()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            VoiceInfo voice = synth.Voice;
            PromptBuilder builder = new PromptBuilder();
            SpeechSynthesizerState state = SpeechSynthesizerState.Ready;
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Hello World");
            synth.SpeakAsync("Async speech");
            synth.Rate = 0;
            synth.Volume = 100;
            synth.SelectVoice("Voice Name");
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

    // System.Windows.Forms Examples
    public class WindowsFormsExamples
    {
        public void FormOperations()
        {
            Form form = new Form();
            Button button = new Button();
            TextBox textBox = new TextBox();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();
            ListBox listBox = new ListBox();
            MenuStrip menuStrip = new MenuStrip();
            ToolStrip toolStrip = new ToolStrip();
            StatusStrip statusStrip = new StatusStrip();
            NotifyIcon notifyIcon = new NotifyIcon();
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
            XmlNodeList nodeList = doc.SelectNodes("//path");
            XmlNamespaceManager nsManager = new XmlNamespaceManager(new NameTable());
            XmlSchema schema = new XmlSchema();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlCDataSection cdata = doc.CreateCDataSection("data");
        }
    }
}