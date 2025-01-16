using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.WebAssembly;
using Microsoft.JSInterop;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Json;

namespace Blazor
{
    // Microsoft.AspNetCore.Components Example
    public class ComponentExample : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        protected override void OnInitialized()
        {
            Title = "Welcome to Blazor";
        }
    }

    // Microsoft.AspNetCore.Components.Web Example
    public class EventExample : ComponentBase
    {
        private string message = "";

        private void HandleClick(MouseEventArgs e)
        {
            message = $"Mouse clicked at position: {e.ClientX}, {e.ClientY}";
        }
    }

    // Microsoft.AspNetCore.Components.Forms Example
    public class FormExample : ComponentBase
    {
        private Model model = new Model();

        private void HandleValidSubmit(EditContext context)
        {
            // Process the valid form
        }
    }

    // Microsoft.AspNetCore.Components.Authorization Example
    public class AuthExample : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        private async Task GetUserInfo()
        {
            var authState = await authenticationStateTask;
            var user = authState.User;
        }
    }

    // Microsoft.AspNetCore.Components.Routing Example
    [Route("/counter")]
    public class RouteExample : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }
    }

    // Microsoft.AspNetCore.Components.Server Example
    public class CircuitHandlerExample : CircuitHandler
    {
        public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }

    // Microsoft.AspNetCore.Components.WebAssembly Example
    public class WasmExample
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            await builder.Build().RunAsync();
        }
    }

    // Microsoft.JSInterop Example
    public class JsInteropExample : ComponentBase
    {
        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        private async Task CallJavaScript()
        {
            await JSRuntime.InvokeVoidAsync("alert", "Hello from Blazor!");
        }
    }

    // Microsoft.Extensions.DependencyInjection Example
    public class ServiceExample
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDataService, DataService>();
            services.AddBlazorWebAssembly();
        }
    }

    // Microsoft.Extensions.Logging Example
    public class LoggingExample : ComponentBase
    {
        [Inject]
        private ILogger<LoggingExample> Logger { get; set; }

        private void LogMessage()
        {
            Logger.LogInformation("Component rendered at {time}", DateTime.UtcNow);
        }
    }

    // System.Net.Http Example
    public class HttpExample : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }

        private async Task FetchData()
        {
            var response = await Http.GetAsync("api/data");
            var content = await response.Content.ReadAsStringAsync();
        }
    }

    // System.Net.Http.Json Example
    public class JsonExample : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }

        private async Task<WeatherForecast[]> GetForecastAsync()
        {
            return await Http.GetFromJsonAsync<WeatherForecast[]>("api/weather");
        }
    }

    // System.Collections.Generic Example
    public class StateExample : ComponentBase
    {
        private List<string> items = new List<string>();
        private Dictionary<string, object> properties = new Dictionary<string, object>();

        protected override void OnInitialized()
        {
            items.Add("Blazor Item");
        }
    }

    // System.Threading.Tasks Example
    public class AsyncExample : ComponentBase
    {
        private async Task LoadDataAsync()
        {
            await Task.Delay(1000); // Simulate loading
            StateHasChanged();
        }
    }

    // System Example
    public class SystemExample : ComponentBase
    {
        private void BasicOperations()
        {
            DateTime now = DateTime.UtcNow;
            Guid componentId = Guid.NewGuid();
            string formatted = String.Format("Component: {0}", componentId);
            TimeSpan renderTime = TimeSpan.FromMilliseconds(100);
        }
    }
}
