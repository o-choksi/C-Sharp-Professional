using System;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Helpers;
using System.Web.WebPages;
using System.Web.Routing;
using System.Web.Optimization;
using System.Web.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Razor
{
    // Web Forms View Engine
    public class WebFormsViewExample : System.Web.Mvc.ViewPage
    {
        public override void Execute()
        {
            WriteLiteral("Hello from Web Forms View Engine");
        }
    }

    // Web Forms Controls
    public class WebControlExample : System.Web.UI.Page 
    {
        protected Label messageLabel;
        protected void Page_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "Hello from Web Controls";
        }
    }

    // Web Helpers
    public class WebHelperExample
    {
        public void UseWebHelpers()
        {
            var chart = new Chart(width: 600, height: 400);
            chart.AddTitle("Sample Chart");
        }
    }

    // Web Pages
    public class WebPagesExample : WebPage
    {
        public override void Execute()
        {
            WriteLiteral("Hello from Web Pages");
        }
    }

    // Routing
    public class LegacyRouteExample
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = "" }
            );
        }
    }

    // Bundle Configuration
    public class BundleConfigExample
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
        }
    }

    // Forms Authentication
    public class FormsAuthExample
    {
        public void AuthenticateUser(string username, string password)
        {
            FormsAuthentication.SetAuthCookie(username, false);
            FormsAuthentication.RedirectFromLoginPage(username, false);
        }
    }

    // Web Forms Master Pages
    public class MasterPageExample : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Content from Master Page");
        }
    }

    // HTTP Modules
    public class CustomHttpModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(OnBeginRequest);
        }

        public void Dispose() { }

        private void OnBeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Write("Begin Request");
        }
    }

    // HTTP Handlers
    public class CustomHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Custom HTTP Handler Response");
        }
    }

    // Razor Components Example
    public class RazorComponentExample : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddContent(1, Title);
            builder.CloseElement();
        }
    }

    // SignalR Hub Example
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

    // Identity Example
    public class IdentityExample
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IdentityExample(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task CreateUser(string email, string password)
        {
            var user = new IdentityUser { UserName = email, Email = email };
            await _userManager.CreateAsync(user, password);
        }
    }

    // Authorization Example
    [Authorize(Roles = "Admin")]
    public class SecureController : Controller
    {
        public IActionResult SecureEndpoint()
        {
            return Ok("Secure data");
        }
    }

    // Configuration Example
    public class ConfigurationExample
    {
        private readonly IConfiguration _configuration;

        public ConfigurationExample(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }

    // Dependency Injection Example
    public class ServiceExample
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMyService, MyService>();
            services.AddSingleton<IGlobalService, GlobalService>();
        }
    }

    // HTML Helper Example
    public class HtmlHelperExample
    {
        public IHtmlContent CreateCustomElement()
        {
            return new HtmlString("<div class='custom'>Custom Element</div>");
        }
    }

    // Hosting Environment Example
    public class HostingExample
    {
        private readonly IWebHostEnvironment _environment;

        public HostingExample(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public string GetWebRootPath()
        {
            return _environment.WebRootPath;
        }
    }

    // Razor Page Model Example
    public class RazorPageModelExample : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Welcome to Razor Pages";
        }
    }

    // Tag Helper Example
    public class CustomTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "custom-tag");
            output.Content.SetContent("Custom Tag Helper Content");
        }
    }
}
