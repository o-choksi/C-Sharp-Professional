// This file provides an overview of commonly used ASP.NET namespaces and libraries

using System;

namespace AspNet
{
    // Core ASP.NET MVC functionality
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller {
        public IActionResult Index() => View();
    }

    // HTTP request/response handling 
    using Microsoft.AspNetCore.Http;
    public void ProcessRequest(HttpContext context) {
        context.Response.WriteAsync("Hello World");
    }

    // Dependency injection
    using Microsoft.Extensions.DependencyInjection;
    public void ConfigureServices(IServiceCollection services) {
        services.AddScoped<IMyService, MyService>();
    }

    // Entity Framework Core
    using Microsoft.EntityFrameworkCore;
    public class BlogContext : DbContext {
        public DbSet<Blog> Blogs { get; set; }
    }

    // Authentication and user management
    using Microsoft.AspNetCore.Identity;
    public class UserManager {
        private readonly UserManager<IdentityUser> _userManager;
        public async Task CreateUser(string email) =>
            await _userManager.CreateAsync(new IdentityUser(email));
    }

    // Logging
    using Microsoft.Extensions.Logging;
    public class LoggingExample {
        private readonly ILogger _logger;
        public void Log() => _logger.LogInformation("Log message");
    }

    // Authorization
    using Microsoft.AspNetCore.Authorization;
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller {
        public IActionResult SecureEndpoint() => Ok();
    }

    // Real-time communication
    using Microsoft.AspNetCore.SignalR;
    public class ChatHub : Hub {
        public async Task SendMessage(string message) =>
            await Clients.All.SendAsync("ReceiveMessage", message);
    }

    // Configuration
    using Microsoft.Extensions.Configuration;
    public class ConfigExample {
        public string GetSetting(IConfiguration config) =>
            config.GetValue<string>("AppSettings:Key");
    }

    // Hosting and startup
    using Microsoft.AspNetCore.Hosting;
    public class Program {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }

    // Static file handling
    using Microsoft.AspNetCore.StaticFiles;
    public void ConfigureStaticFiles(IApplicationBuilder app) {
        app.UseStaticFiles();
    }

    // Session management
    using Microsoft.AspNetCore.Session;
    public void UseSessionExample(HttpContext context) {
        context.Session.SetString("UserKey", "UserValue");
    }

    // HTTP client
    using System.Net.Http;
    public class ApiClient {
        private readonly HttpClient _client = new HttpClient();
        public async Task<string> GetData() =>
            await _client.GetStringAsync("https://api.example.com/data");
    }

    // Routing
    using Microsoft.AspNetCore.Routing;
    public void ConfigureRoutes(IEndpointRouteBuilder endpoints) {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }
} 