using Autofac;
using System;
using Tripper.Services.Entities.Abstract;

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
