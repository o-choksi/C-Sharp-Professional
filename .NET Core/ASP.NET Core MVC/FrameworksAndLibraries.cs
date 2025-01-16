using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Cors;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AspNetCoreMVC
{
    // 1. Microsoft.AspNetCore.Mvc Example
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    // 2. Microsoft.AspNetCore.Mvc.Abstractions Example
    public class ActionDescriptorExample
    {
        public void ProcessActionDescriptor(ActionDescriptor descriptor)
        {
            var displayName = descriptor.DisplayName;
            var routeValues = descriptor.RouteValues;
        }
    }

    // 3. Microsoft.AspNetCore.Mvc.ActionConstraints Example
    public class CustomActionConstraint : IActionConstraint
    {
        public int Order => 0;

        public bool Accept(ActionConstraintContext context)
        {
            return context.RouteContext.HttpContext.Request.Headers.ContainsKey("Custom-Header");
        }
    }

    // 4. Microsoft.AspNetCore.Mvc.ApiExplorer Example
    public class ApiDescriptionExample
    {
        private readonly IApiDescriptionGroupCollectionProvider _apiExplorer;

        public ApiDescriptionExample(IApiDescriptionGroupCollectionProvider apiExplorer)
        {
            _apiExplorer = apiExplorer;
        }
    }

    // 5. Microsoft.AspNetCore.Mvc.ApplicationModels Example
    public class CustomControllerModel : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            controller.ControllerName = controller.ControllerName.Replace("Controller", "");
        }
    }

    // 6. Microsoft.AspNetCore.Mvc.Authorization Example
    public class AuthorizedController : Controller
    {
        [TypeFilter(typeof(AuthorizeFilter))]
        public IActionResult SecureEndpoint()
        {
            return Ok();
        }
    }

    // 7. Microsoft.AspNetCore.Mvc.Controllers Example
    public class ControllerExample : ControllerBase
    {
        public ActionResult<string> GetValue()
        {
            return "Value";
        }
    }

    // 8. Microsoft.AspNetCore.Mvc.Cors Example
    [EnableCors("PolicyName")]
    public class CorsController : Controller
    {
        public IActionResult CrossOriginRequest()
        {
            return Ok();
        }
    }

    // 9. Microsoft.AspNetCore.Mvc.Filters Example
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

    // 10. Microsoft.AspNetCore.Mvc.Formatters Example
    public class CustomInputFormatter : InputFormatter
    {
        public override bool CanRead(InputFormatterContext context)
        {
            return context.HttpContext.Request.ContentType == "application/custom";
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            return InputFormatterResult.SuccessAsync(new object());
        }
    }

    // 11. Microsoft.AspNetCore.Mvc.Infrastructure Example
    public class ActionContextExample
    {
        private readonly IActionContextAccessor _actionContextAccessor;

        public ActionContextExample(IActionContextAccessor actionContextAccessor)
        {
            _actionContextAccessor = actionContextAccessor;
        }
    }

    // 12. Microsoft.AspNetCore.Mvc.ModelBinding Example
    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            bindingContext.Result = ModelBindingResult.Success(value.FirstValue);
            return Task.CompletedTask;
        }
    }

    // 13. Microsoft.AspNetCore.Mvc.Razor Example
    public class CustomRazorPage : RazorPage<dynamic>
    {
        public override Task ExecuteAsync()
        {
            WriteLiteral("Hello from custom Razor page");
            return Task.CompletedTask;
        }
    }

    // 14. Microsoft.AspNetCore.Mvc.Routing Example
    public class RoutingExample : Controller
    {
        private readonly LinkGenerator _linkGenerator;

        public RoutingExample(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }
    }

    // 15. Microsoft.AspNetCore.Mvc.TagHelpers Example
    public class CustomTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent("Custom Tag Helper Content");
        }
    }

    // 16. Microsoft.AspNetCore.Mvc.ViewComponents Example
    public class CustomViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }

    // 17. Microsoft.AspNetCore.Mvc.ViewFeatures Example
    public class ViewFeaturesExample : Controller
    {
        public IActionResult UseViewData()
        {
            ViewData["Message"] = "Hello from ViewData";
            return View();
        }
    }

    // 18. Microsoft.AspNetCore.Mvc.RazorPages Example
    public class CustomPageModel : PageModel
    {
        public void OnGet()
        {
            // Handle GET request
        }
    }

    // 19. Microsoft.AspNetCore.Mvc.ViewEngines Example
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
        {
            return ViewEngineResult.NotFound(viewName, new string[] { });
        }

        public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
        {
            return ViewEngineResult.NotFound(viewPath, new string[] { });
        }
    }

    // 20. Microsoft.AspNetCore.Mvc.DataAnnotations Example
    public class ValidationExample
    {
        private readonly IValidationAttributeAdapterProvider _validationProvider;

        public ValidationExample(IValidationAttributeAdapterProvider validationProvider)
        {
            _validationProvider = validationProvider;
        }
    }
}
