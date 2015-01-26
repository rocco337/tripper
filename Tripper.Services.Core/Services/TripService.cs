using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripper.Services.Entities.Abstract;
using Tripper.Services.Entities.Entities;

namespace Tripper.Services.Core
{
    public class TripService : ITripService
    {
        public void Add(TripEntity entity)
        {
            var context = new DataContext();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.LazyLoadingEnabled = true;

            context.Trips.Add(entity);
            context.Dispose();
        }

        public TripEntity GetDetails()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TripEntity> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
