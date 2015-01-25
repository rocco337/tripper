using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Tripper.Services.Trip
{
    public class HttpConf : HttpConfiguration
    {
        public HttpConf()
        {
            ConfigureRoutes();
            ConfigureJsonSerialization();
        }

        private void ConfigureRoutes()
        {
            Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private void ConfigureJsonSerialization()
        {
            var jsonSettings = Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            Formatters.Remove(Formatters.XmlFormatter);
        }

    }
}
