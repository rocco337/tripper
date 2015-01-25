using Microsoft.Owin;
using Owin;
using Tripper.Services.Core;
using Tripper.Services.Entities.Abstract;
using Tripper.Services.Trip;
using Autofac.Integration.WebApi;
using Autofac;
using System.Reflection;

[assembly: OwinStartup(typeof(Tripper.Services.Host.Startup))]

namespace Tripper.Services.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = DependecyResolver.ServicesModule();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterApiControllers(assembly);

            var container = builder.Build();
            app.UseAutofacMiddleware(container);


            var config = new HttpConf();
            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;

            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

    }

   

   

    
}
