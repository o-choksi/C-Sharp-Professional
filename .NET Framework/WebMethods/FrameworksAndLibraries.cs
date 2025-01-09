using System;

namespace WebMethods
{
    // Basic Web Method
    using System.Web.Services;
    public class BasicWebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello, World!";
        }
    }

    // Web Method with Parameters
    using System.Web.Services;
    public class ParameterizedWebService
    {
        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    // Web Method with Complex Type
    using System.Web.Services;
    public class ComplexTypeWebService
    {
        [WebMethod]
        public Customer GetCustomer(int id)
        {
            return new Customer { Id = id, Name = "John Doe" };
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }

    // Web Method with Session State
    using System.Web.Services;
    public class SessionWebService
    {
        [WebMethod(EnableSession = true)]
        public void StoreInSession(string key, string value)
        {
            System.Web.HttpContext.Current.Session[key] = value;
        }
    }

    // Web Method with Cache
    using System.Web.Services;
    public class CachedWebService
    {
        [WebMethod(CacheDuration = 60)]
        public string GetCachedData()
        {
            return "This result will be cached for 60 seconds";
        }
    }

    // Web Method with Authentication
    using System.Web.Services;
    public class SecureWebService
    {
        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("Credentials")]
        public string GetSecureData()
        {
            return "Secure data";
        }
    }

    // Web Method with Transaction
    using System.Web.Services;
    using System.EnterpriseServices;
    public class TransactionalWebService
    {
        [WebMethod]
        [Transaction(TransactionOption.Required)]
        public void PerformTransaction()
        {
            // Transaction logic here
        }
    }

    // Web Method with Custom SOAP Headers
    using System.Web.Services;
    using System.Web.Services.Protocols;
    public class CustomHeaderWebService
    {
        public class AuthHeader : SoapHeader
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [WebMethod]
        [SoapHeader("AuthHeader")]
        public string AuthenticatedMethod()
        {
            return "Authenticated response";
        }
    }

    // Web Method with Async Pattern
    using System.Web.Services;
    public class AsyncWebService
    {
        [WebMethod]
        public IAsyncResult BeginOperation(AsyncCallback callback, object state)
        {
            // Async operation logic
            return null;
        }

        [WebMethod]
        public void EndOperation(IAsyncResult result)
        {
            // Complete async operation
        }
    }

    // Web Method with Description
    using System.Web.Services;
    using System.ComponentModel;
    public class DocumentedWebService
    {
        [WebMethod(Description = "This method performs an important operation")]
        [System.Xml.Serialization.XmlInclude(typeof(OperationResult))]
        public OperationResult PerformOperation()
        {
            return new OperationResult { Success = true };
        }

        public class OperationResult
        {
            public bool Success { get; set; }
        }
    }
}