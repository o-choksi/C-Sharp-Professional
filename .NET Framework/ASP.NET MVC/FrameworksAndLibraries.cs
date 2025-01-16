using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Mvc.Filters;
using System.Web.Mvc.Routing;
using System.Web.Mvc.Async;
using System.Web.Mvc.ModelBinding;
using System.Web.Mvc.Properties;

namespace ASPNetMVC
{
    // System Examples
    public class SystemExamples
    {
        public void DateTimeExample()
        {
            DateTime now = DateTime.Now;
            TimeSpan duration = TimeSpan.FromHours(1);
            Guid uniqueId = Guid.NewGuid();
            Uri url = new Uri("http://example.com");
            Exception ex = new Exception("Error message");
            Type type = typeof(string);
            Version ver = new Version(1, 0);
            Random rand = new Random();
            Math.Round(3.14159, 2);
            Convert.ToString(42);
        }
    }

    // System.Web Examples
    public class WebExamples
    {
        public void HttpExamples(HttpContext context)
        {
            HttpCookie cookie = new HttpCookie("name", "value");
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            HttpServerUtility server = context.Server;
            HttpApplicationState app = context.Application;
            HttpBrowserCapabilities browser = context.Request.Browser;
            HttpCachePolicy cache = context.Response.Cache;
            HttpFileCollection files = context.Request.Files;
            HttpModuleCollection modules = context.ApplicationInstance.Modules;
            HttpStaticObjectsCollection staticObjects = context.Application.StaticObjects;
        }
    }

    // System.Web.Mvc Examples
    public class MvcExamples : Controller
    {
        public ActionResult Example1() => View();
        public JsonResult Example2() => Json(new { data = "value" });
        public ContentResult Example3() => Content("text");
        public FileResult Example4() => File(new byte[] { }, "application/pdf");
        public RedirectResult Example5() => Redirect("/home");
        public PartialViewResult Example6() => PartialView();
        public EmptyResult Example7() => new EmptyResult();
        public HttpStatusCodeResult Example8() => new HttpStatusCodeResult(200);
        public HttpNotFoundResult Example9() => HttpNotFound();
        public HttpUnauthorizedResult Example10() => new HttpUnauthorizedResult();
    }

    // System.Web.Mvc.Ajax Examples
    public class AjaxExamples : Controller
    {
        public void AjaxMethods()
        {
            AjaxOptions options1 = new AjaxOptions { UpdateTargetId = "div1" };
            AjaxOptions options2 = new AjaxOptions { Confirm = "Are you sure?" };
            AjaxOptions options3 = new AjaxOptions { HttpMethod = "POST" };
            AjaxOptions options4 = new AjaxOptions { OnBegin = "startFunction" };
            AjaxOptions options5 = new AjaxOptions { OnComplete = "completeFunction" };
            AjaxOptions options6 = new AjaxOptions { OnFailure = "errorFunction" };
            AjaxOptions options7 = new AjaxOptions { OnSuccess = "successFunction" };
            AjaxOptions options8 = new AjaxOptions { LoadingElementId = "loader" };
            AjaxOptions options9 = new AjaxOptions { InsertionMode = InsertionMode.Replace };
            AjaxOptions options10 = new AjaxOptions { AllowCache = false };
        }
    }

    // System.Web.Mvc.Html Examples
    public class HtmlExamples : Controller
    {
        public void HtmlHelperMethods(HtmlHelper html)
        {
            html.TextBox("name");
            html.Password("password");
            html.CheckBox("agree");
            html.RadioButton("choice", "value");
            html.DropDownList("items");
            html.TextArea("description");
            html.Hidden("id");
            html.Label("fieldName");
            html.ActionLink("Click", "Action");
            html.ValidationMessage("field");
        }
    }

    // System.Web.Mvc.Filters Examples
    public class FilterExamples
    {
        [OutputCache(Duration = 300)]
        [Authorize]
        [HandleError]
        [RequireHttps]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [ActionName("CustomName")]
        [NonAction]
        [ChildActionOnly]
        [AcceptVerbs(HttpVerbs.Post)]
        public void FilteredMethod() { }
    }

    // System.Web.Mvc.Routing Examples
    public class RoutingExamples
    {
        public void RouteExamples(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Route1", "blog/{year}/{month}");
            routes.MapRoute("Route2", "{controller}/{action}");
            routes.MapRoute("Route3", "api/{controller}");
            routes.MapRoute("Route4", "{culture}/{controller}");
            routes.MapRoute("Route5", "pages/{*url}");
            routes.MapRoute("Route6", "{controller}.aspx/{action}");
            routes.MapRoute("Route7", "{area}/{controller}");
            routes.MapRoute("Route8", "static/{filename}");
            routes.MapRoute("Route9", "{controller}/{id:int}");
        }
    }

    // System.Web.Mvc.Async Examples
    public class AsyncExamples : AsyncController
    {
        public async Task<ActionResult> Action1() => await Task.FromResult(View());
        public async Task<JsonResult> Action2() => await Task.FromResult(Json(new { }));
        public async Task<FileResult> Action3() => await Task.FromResult(File(new byte[] { }, "text/plain"));
        public async Task<ContentResult> Action4() => await Task.FromResult(Content("text"));
        public async Task<RedirectResult> Action5() => await Task.FromResult(Redirect("/"));
        public async Task<PartialViewResult> Action6() => await Task.FromResult(PartialView());
        public async Task<EmptyResult> Action7() => await Task.FromResult(new EmptyResult());
        public async Task<HttpStatusCodeResult> Action8() => await Task.FromResult(new HttpStatusCodeResult(200));
        public async Task<HttpNotFoundResult> Action9() => await Task.FromResult(HttpNotFound());
        public async Task<ViewResult> Action10() => await Task.FromResult(View());
    }

    // System.Web.Mvc.ModelBinding Examples
    public class ModelBindingExamples
    {
        [ModelBinder(typeof(CustomBinder))]
        public class Model1 { }

        public class CustomBinder : IModelBinder
        {
            public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) => null;
        }

        public void BindingExamples(ModelBindingContext context)
        {
            context.ModelMetadata.ShowForDisplay = true;
            context.ModelMetadata.ShowForEdit = true;
            context.ModelMetadata.IsRequired = true;
            context.ModelMetadata.DisplayName = "Name";
            context.ModelMetadata.Description = "Description";
            context.ModelMetadata.Order = 1;
            context.ModelMetadata.HideSurroundingHtml = true;
            context.ModelMetadata.TemplateHint = "Template";
            context.ModelMetadata.IsReadOnly = false;
            context.ModelMetadata.ConvertEmptyStringToNull = true;
        }
    }

    // System.Web.Mvc.Properties Examples
    public class PropertiesExamples
    {
        public void PropertyExamples()
        {
            var resources = new Resources();
            string str1 = Resources.ArgumentCannotBeNullOrEmpty;
            string str2 = Resources.PropertyValueInvalid;
            string str3 = Resources.PropertyValueRequired;
            string str4 = Resources.ViewDataDictionary_WrongTModelType;
            string str5 = Resources.Common_PropertyNotFound;
            string str6 = Resources.Common_NullOrEmpty;
            string str7 = Resources.DefaultModelBinder_ValueRequired;
            string str8 = Resources.ModelBinderDictionary_MultipleAttributes;
            string str9 = Resources.Resources_UnsupportedFormat;
            string str10 = Resources.ChildActionOnlyAttribute_MustBeInChildRequest;
        }
    }
}