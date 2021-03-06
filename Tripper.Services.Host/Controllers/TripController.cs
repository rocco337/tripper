﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Tripper.Services.Entities.Abstract;

namespace Tripper.Services.Host.Controllers
{
    public class TripController : ApiController
    {
        private readonly ITripService _tripService;

        public TripController(ITripService tripperService)
        {
            _tripService = tripperService;
        }

        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 1000);
        }

        [HttpGet]
        public bool AddNew()
        {
            _tripService.Add(new Entities.Entities.TripEntity()
            {
                Name = "Test trip",
                Description = "Test trip to the tes location"
            });

            return true;
        }
    }
}
