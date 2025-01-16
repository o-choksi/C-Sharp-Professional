using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration; 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.SignalR;
using System.Net.Http;
using Microsoft.Extensions.Hosting;

namespace AspNetCore
{

    // Middleware Example
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }

    // Configuration Example
    public class ConfigurationService
    {
        private readonly IConfiguration _config;

        public ConfigurationService(IConfiguration config)
        {
            _config = config;
        }

        public string GetSetting(string key)
        {
            return _config[key];
        }
    }

    // Dependency Injection Example
    public interface IMyService
    {
        void DoWork();
    }

    public class MyService : IMyService
    {
        public void DoWork()
        {
            // Implementation
        }
    }

    // Logging Example
    public class LoggingService
    {
        private readonly ILogger<LoggingService> _logger;

        public LoggingService(ILogger<LoggingService> logger)
        {
            _logger = logger;
        }

        public void LogMessage(string message)
        {
            _logger.LogInformation(message);
        }
    }

    // Caching Example
    public class CacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void SetCache(string key, object value)
        {
            _cache.Set(key, value);
        }
    }

    // Entity Framework Core Example
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

    // Authentication Example
    public class AuthenticationService
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationService(IAuthenticationService authService)
        {
            _authService = authService;
        }

        public async Task SignInAsync(HttpContext context, string scheme)
        {
            await _authService.SignInAsync(context, scheme, new ClaimsPrincipal());
        }
    }

    // Authorization Example
    [Authorize(Policy = "AdminOnly")]
    public class SecureController : Controller
    {
        public IActionResult Secure()
        {
            return Ok();
        }
    }

    // SignalR Example
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }

    // Action Filters Example
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Before action execution
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // After action execution
        }
    }

    // HTTP Client Example
    public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetDataAsync(string url)
        {
            return await _client.GetStringAsync(url);
        }
    }

    // Routing Example
    public class RouteConfig
    {
        public static void Configure(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }

    // Model Binding Example
    public class ModelBindingExample : Controller
    {
        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(user);
        }
    }

    // View Components Example
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

    // Tag Helpers Example
    public class CustomTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent("Custom Content");
        }
    }

    // Options Pattern Example
    public class AppSettings
    {
        public string ConnectionString { get; set; }
    }

    public class OptionsExample
    {
        private readonly AppSettings _settings;

        public OptionsExample(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }
    }

    // Health Checks Example
    public class HealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy());
        }
    }

    // Background Services Example
    public class TimedHostedService : IHostedService
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Dispose();
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            // Background work
        }
    }

    // Response Compression Example
    public class CompressionExample
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseResponseCompression();
        }
    }
}
