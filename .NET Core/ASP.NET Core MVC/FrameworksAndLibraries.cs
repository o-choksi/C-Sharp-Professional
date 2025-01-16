using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

namespace AspNetCoreMVC
{
    // 1. Microsoft.AspNetCore.Mvc Example
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    // 2. Microsoft.AspNetCore.Http Example
    public class HttpContextExample
    {
        public void ProcessRequest(HttpContext context)
        {
            var path = context.Request.Path;
            context.Response.WriteAsync("Hello World");
        }
    }

    // 3. Microsoft.AspNetCore.Routing Example
    public class RouteExample
    {
        public void ConfigureRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }

    // 4. Microsoft.AspNetCore.Builder Example
    public class StartupExample
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    // 5. Microsoft.AspNetCore.Hosting Example
    public class HostingExample
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    // 6. Microsoft.AspNetCore.Identity Example
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

    // 7. Microsoft.AspNetCore.Authorization Example
    [Authorize]
    public class SecuredController : Controller
    {
        [AllowAnonymous]
        public IActionResult PublicAction()
        {
            return Ok();
        }
    }

    // 8. Microsoft.Extensions.Configuration Example
    public class ConfigExample
    {
        private readonly IConfiguration _configuration;

        public ConfigExample(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }

    // 9. Microsoft.Extensions.DependencyInjection Example
    public class ServiceExample
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMyService, MyService>();
            services.AddControllers();
        }
    }

    // 10. Microsoft.Extensions.Logging Example
    public class LogExample
    {
        private readonly ILogger<LogExample> _logger;

        public LogExample(ILogger<LogExample> logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.LogInformation("Method executed at {time}", DateTime.UtcNow);
        }
    }

    // 11. Microsoft.Extensions.Caching.Memory Example
    public class CacheExample
    {
        private readonly IMemoryCache _cache;

        public CacheExample(IMemoryCache cache)
        {
            _cache = cache;
        }

        public object GetOrCreate(string key)
        {
            return _cache.GetOrCreate(key, entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromHours(1);
                return DateTime.Now;
            });
        }
    }

    // 12. Microsoft.EntityFrameworkCore Example
    public class EFExample : DbContext
    {
        public EFExample(DbContextOptions<EFExample> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
        }
    }

    // 13. System.Collections.Generic Example
    public class CollectionExample
    {
        public List<string> GetItems()
        {
            return new List<string> { "Item1", "Item2", "Item3" };
        }

        public Dictionary<int, string> GetMappings()
        {
            return new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" }
            };
        }
    }

    // 14. System.Threading.Tasks Example
    public class AsyncExample
    {
        public async Task<string> GetDataAsync()
        {
            await Task.Delay(1000); // Simulate async work
            return "Data";
        }

        public async Task ProcessDataAsync()
        {
            var tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(GetDataAsync());
            }
            await Task.WhenAll(tasks);
        }
    }

    // 15. System Example
    public class SystemExample
    {
        public void BasicOperations()
        {
            DateTime now = DateTime.UtcNow;
            Guid uniqueId = Guid.NewGuid();
            string formatted = String.Format("Time: {0}", now);
            TimeSpan duration = TimeSpan.FromHours(1);
        }
    }
}
