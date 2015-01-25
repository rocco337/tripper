using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tripper.Services.Core
{
    public class DependecyResolver
    {
        public static ContainerBuilder ServicesModule()
        {
            var builder = new ContainerBuilder();
          
            builder.Register(c => new TripService()).As<ITripService>().InstancePerRequest();

            return builder;
        }
    }
}
