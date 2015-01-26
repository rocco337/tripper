using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripper.Services.Entities.Entities;

namespace Tripper.Services.Entities.Abstract
{
    public interface ITripService
    {
        IEnumerable<TripEntity> GetList();
        TripEntity GetDetails();

        void Add(TripEntity entity);
    }
}
