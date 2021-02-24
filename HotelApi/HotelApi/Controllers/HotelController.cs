using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {

        private readonly ILogger<HotelController> _logger;

        public HotelController(ILogger<HotelController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            var hotelList = new List<Hotel>() { 
                new Hotel { Name = "Beach Hotel", Address = "Beach Side", Description = "Surf Hotel", Score = 4 },
                new Hotel { Name = "Castle Hotel", Address = "Mountain Road", Description = "Historic Hotel", Score = 5 },
                new Hotel { Name = "Feast Hotel", Address = "Pub Road", Description = "Gourmet Hotel", Score = 3 }
            };

            return hotelList;
        }
    }
}
