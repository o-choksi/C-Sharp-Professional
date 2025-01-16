using System.Web.Ajax;
using System.Web.Mvc.Ajax;
using System.Web.UI.AjaxControlToolkit;
using Microsoft.Ajax.Utilities;
using Microsoft.Web.Ajax;
using Microsoft.Web.Ajax.Controls;
using Microsoft.Web.Ajax.Behaviors;
using Microsoft.Web.Ajax.Extensions;
using Microsoft.Web.Ajax.Services;
using Microsoft.Web.Ajax.UI;

namespace Ajax
{
    public class WebMethodExample
    {
        [WebMethod]
        public static string GetServerTime()
        {
            return DateTime.Now.ToString();
        }
    }

    public class AjaxControlExample
    {
        public void ConfigureAjaxControl()
        {
            var control = new AjaxControl
            {
                ID = "ajaxControl1",
                EnableViewState = false,
                UpdateMode = UpdatePanelUpdateMode.Conditional
            };
        }
    }

    public class AjaxBehaviorExample
    {
        public void ConfigureBehavior()
        {
            var behavior = new AjaxBehavior
            {
                EnablePartialRendering = true,
                PostBackUrl = "~/Handler.ashx",
                OnComplete = "handleComplete"
            };
        }
    }

    public class AjaxExtensionExample
    {
        public void ConfigureExtension()
        {
            var extension = new AjaxExtension
            {
                TargetControlID = "mainContent",
                EnableCaching = true,
                CacheDuration = 300
            };
        }
    }

    public class AjaxServiceExample
    {
        [WebService(Namespace = "http://tempuri.org/")]
        public class MyAjaxService : System.Web.Services.WebService
        {
            [WebMethod]
            public string ProcessData(string input)
            {
                return $"Processed: {input}";
            }
        }
    }

    public class AjaxUIExample
    {
        public void ConfigureUI()
        {
            var uiElement = new AjaxUIControl
            {
                Visible = true,
                EnableTheming = true,
                Theme = "Modern"
            };
        }
    }

    public class AjaxUtilitiesExample
    {
        public string MinifyContent()
        {
            var minifier = new Minifier();
            return minifier.MinifyJavaScript("function test() { alert('Hello'); }");
        }
    }

    public class AjaxControlToolkitExample
    {
        public void ConfigureToolkit()
        {
            var calendar = new CalendarExtender
            {
                TargetControlID = "txtDate",
                Format = "dd/MM/yyyy",
                PopupButtonID = "imgCalendar"
            };
        }
    }

    public class MvcAjaxExample
    {
        public AjaxOptions ConfigureAjaxOptions()
        {
            return new AjaxOptions
            {
                InsertionMode = InsertionMode.Replace,
                UpdateTargetId = "resultDiv",
                LoadingElementId = "loading"
            };
        }
    }

    public class WebAjaxExample
    {
        public void ConfigureWebAjax()
        {
            var handler = new AjaxRequestHandler
            {
                EnableCompression = true,
                Timeout = 30000,
                CacheControl = "no-cache"
            };
        }
    }
}
