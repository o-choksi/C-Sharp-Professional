using System;

namespace AspNet
{
    // Classic ASP.NET Web Forms
    using System.Web.UI;
    public class HomePage : Page 
    {
        protected void Page_Load(object sender, EventArgs e) 
        {
            Response.Write("Hello World");
        }
    }

    // HTTP Handling
    using System.Web;
    public class HttpHandler : IHttpHandler 
    {
        public void ProcessRequest(HttpContext context) 
        {
            context.Response.Write("Hello World");
        }
        public bool IsReusable => false;
    }

    // Classic ASP.NET Services
    using System.Web.Services;
    [WebService(Namespace = "http://tempuri.org/")]
    public class LegacyWebService : WebService 
    {
        [WebMethod]
        public string HelloWorld() => "Hello World";
    }

    // Classic ADO.NET
    using System.Data;
    using System.Data.SqlClient;
    public class DataAccess 
    {
        public DataSet GetData() 
        {
            using(var conn = new SqlConnection("connection_string")) 
            {
                var cmd = new SqlCommand("SELECT * FROM Table", conn);
                var adapter = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
    }

    // ASP.NET Membership
    using System.Web.Security;
    public class UserManager 
    {
        public bool ValidateUser(string username, string password) 
        {
            return Membership.ValidateUser(username, password);
        }
    }

    // ASP.NET Tracing
    using System.Web;
    public class TracingExample 
    {
        public void TraceMessage() 
        {
            HttpContext.Current.Trace.Write("Category", "Message");
        }
    }

    // Forms Authentication
    using System.Web.Security;
    public class AuthExample 
    {
        public void Authenticate(string username) 
        {
            FormsAuthentication.SetAuthCookie(username, false);
        }
    }

    // ASP.NET Caching
    using System.Web.Caching;
    public class CacheExample 
    {
        public void SetCache() 
        {
            HttpContext.Current.Cache.Insert(
                "key", 
                "value",
                null,
                DateTime.Now.AddMinutes(30),
                Cache.NoSlidingExpiration
            );
        }
    }

    // Configuration
    using System.Configuration;
    public class ConfigExample 
    {
        public string GetSetting() 
        {
            return ConfigurationManager.AppSettings["Key"];
        }
    }

    // ASP.NET Application State
    using System.Web;
    public class StateExample 
    {
        public void SetGlobalState() 
        {
            HttpContext.Current.Application["GlobalKey"] = "Value";
        }
    }

    // ASP.NET File Handling
    using System.Web;
    public class FileExample 
    {
        public void HandleUpload() 
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            file.SaveAs(@"C:\uploads\file.txt");
        }
    }

    // Classic ASP.NET Session
    using System.Web.SessionState;
    public class SessionExample 
    {
        public void UseSession() 
        {
            HttpContext.Current.Session["UserKey"] = "UserValue";
        }
    }

    // ASP.NET Web Client
    using System.Net;
    public class WebClientExample 
    {
        private readonly WebClient _client = new WebClient();
        public string GetData() 
        {
            return _client.DownloadString("http://api.example.com/data");
        }
    }

    // URL Routing (Pre-MVC)
    using System.Web.Routing;
    public class RoutingExample 
    {
        public void RegisterRoutes(RouteCollection routes) 
        {
            routes.Add(new Route(
                "{controller}/{action}",
                new PageRouteHandler("~/Default.aspx")
            ));
        }
    }
} 