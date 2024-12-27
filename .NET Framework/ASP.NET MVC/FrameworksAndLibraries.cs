using System;

namespace AspNetMVC
{
    // ASP.NET MVC Controllers
    using System.Web.Mvc;
    public class HomeController : Controller 
    {
        public ActionResult Index() 
        {
            return View("Hello World");
        }
    }

    // ASP.NET MVC Routing
    using System.Web.Mvc;
    using System.Web.Routing;
    public class RouteConfig 
    {
        public static void RegisterRoutes(RouteCollection routes) 
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    // ASP.NET MVC Actions
    using System.Web.Mvc;
    public class ProductController : Controller 
    {
        [HttpPost]
        public ActionResult Create(ProductModel model) 
        {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }

    // ASP.NET MVC Models
    using System.ComponentModel.DataAnnotations;
    public class ProductModel 
    {
        [Required]
        public string Name { get; set; }
        [Range(0, 1000)]
        public decimal Price { get; set; }
    }

    // ASP.NET MVC Filters
    using System.Web.Mvc;
    public class CustomAuthAttribute : AuthorizeAttribute 
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext) 
        {
            return httpContext.User.Identity.IsAuthenticated;
        }
    }

    // ASP.NET MVC HTML Helpers
    using System.Web.Mvc;
    public static class CustomHtmlHelpers 
    {
        public static MvcHtmlString CustomHelper(this HtmlHelper helper, string content) 
        {
            return MvcHtmlString.Create($"<div class='custom'>{content}</div>");
        }
    }

    // ASP.NET MVC Forms Authentication
    using System.Web.Mvc;
    using System.Web.Security;
    public class AccountController : Controller 
    {
        public ActionResult Login(string username, string password) 
        {
            FormsAuthentication.SetAuthCookie(username, false);
            return RedirectToAction("Index", "Home");
        }
    }

    // ASP.NET MVC Caching
    using System.Web.Mvc;
    public class CachingController : Controller 
    {
        [OutputCache(Duration = 300)]
        public ActionResult CachedAction() 
        {
            return View();
        }
    }

    // ASP.NET MVC Configuration
    using System.Configuration;
    using System.Web.Mvc;
    public class ConfigController : Controller 
    {
        public ActionResult GetConfig() 
        {
            ViewBag.Setting = ConfigurationManager.AppSettings["Key"];
            return View();
        }
    }

    // ASP.NET MVC Session State
    using System.Web.Mvc;
    public class SessionController : Controller 
    {
        public ActionResult SetSession() 
        {
            Session["UserKey"] = "UserValue";
            return RedirectToAction("Index");
        }
    }

    // ASP.NET MVC File Handling
    using System.Web.Mvc;
    public class FileController : Controller 
    {
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file) 
        {
            if (file != null) 
            {
                file.SaveAs(Server.MapPath("~/uploads/") + file.FileName);
            }
            return RedirectToAction("Index");
        }
    }

    // ASP.NET MVC Ajax
    using System.Web.Mvc;
    public class AjaxController : Controller 
    {
        [HttpGet]
        public JsonResult GetData() 
        {
            return Json(new { message = "Hello World" }, JsonRequestBehavior.AllowGet);
        }
    }

    // ASP.NET MVC Areas
    using System.Web.Mvc;
    namespace Areas.Admin.Controllers 
    {
        public class DashboardController : Controller 
        {
            public ActionResult Index() 
            {
                return View();
            }
        }
    }
} 