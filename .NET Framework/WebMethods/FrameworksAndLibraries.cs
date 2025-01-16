using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Web.Services.Configuration;
using System.EnterpriseServices;
using System.Xml.Serialization;
using System.ComponentModel;

namespace WebMethods
{
    // Basic SOAP Web Method
    public class BasicSoapWebService 
    {
        [WebMethod]
        public string GetMessage()
        {
            return "Basic SOAP web method";
        }
    }

    // Web Method with SOAP Headers
    public class SoapHeaderWebService
    {
        public class AuthenticationHeader : SoapHeader
        {
            public string Token { get; set; }
        }

        [WebMethod]
        [SoapHeader("Authentication")]
        public string SecureOperation()
        {
            return "Authenticated operation";
        }
    }

    // Web Method with SOAP Extensions
    public class SoapExtensionWebService
    {
        [WebMethod]
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public string ExtendedOperation()
        {
            return "Extended SOAP operation";
        }
    }

    // Web Method with Service Description
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class ServiceDescriptionWebService
    {
        [WebMethod]
        public string DescribedOperation()
        {
            return "Operation with WSDL description";
        }
    }

    // Web Method with Discovery
    [WebServiceAttribute(Description="Discoverable Service")]
    public class DiscoveryWebService
    {
        [WebMethod]
        public string DiscoverableOperation()
        {
            return "Discoverable operation";
        }
    }

    // Web Method with Protocol Configuration
    [WebService(Protocol=WebServiceProtocols.HttpPost)]
    public class ProtocolConfigWebService
    {
        [WebMethod]
        public string ConfiguredOperation()
        {
            return "Protocol configured operation";
        }
    }

    // Web Method with SOAP Document Style
    [WebService(Description="Document Style Service")]
    public class DocumentStyleWebService
    {
        [WebMethod]
        [SoapDocumentMethod(Use=SoapBindingUse.Literal)]
        public string DocumentOperation()
        {
            return "Document style operation";
        }
    }

    // Web Method with Message Contract
    public class MessageContractWebService
    {
        [WebMethod]
        [SoapDocumentMethod(Action="urn:MessageAction")]
        public string MessageOperation()
        {
            return "Message contract operation";
        }
    }

    // Web Method with Custom Serialization
    public class SerializationWebService
    {
        [WebMethod]
        [XmlSerializerFormat]
        public CustomData GetCustomData()
        {
            return new CustomData { Value = "Serialized data" };
        }

        public class CustomData
        {
            public string Value { get; set; }
        }
    }

    // Web Method with Protocol Reflection
    public class ProtocolReflectionWebService
    {
        [WebMethod]
        [SoapRpcMethod]
        public string ReflectionOperation()
        {
            return "Protocol reflection operation";
        }
    }

    // Web Method with Service Behavior
    [WebServiceBinding(EmitConformanceClaims = true)]
    public class ServiceBehaviorWebService
    {
        [WebMethod]
        public string BehaviorOperation()
        {
            return "Service behavior operation";
        }
    }

    // Web Method with SOAP Fault Contract
    public class FaultContractWebService
    {
        [WebMethod]
        [SoapDocumentMethod(ResponseElementName="FaultResponse")]
        public string FaultOperation()
        {
            return "Fault contract operation";
        }
    }

    // Web Method with Service Configuration
    [WebService(Namespace = "http://tempuri.org/")]
    public class ServiceConfigWebService
    {
        [WebMethod]
        public string ConfigOperation()
        {
            return "Service configuration operation";
        }
    }

    // Web Method with Protocol Mapping
    public class ProtocolMappingWebService
    {
        [WebMethod]
        [SoapDocumentMethod(RequestNamespace="http://tempuri.org/")]
        public string MappingOperation()
        {
            return "Protocol mapping operation";
        }
    }

    // Web Method with Service Reference
    public class ServiceReferenceWebService
    {
        [WebMethod]
        [WebServiceBinding(Name="ReferenceBinding")]
        public string ReferenceOperation()
        {
            return "Service reference operation";
        }
    }
}