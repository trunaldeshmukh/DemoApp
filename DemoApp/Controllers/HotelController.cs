using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> Get()
        {
            return new Hotel[]
            {
                new Hotel{Name = "MGM", CityName = "Las Vegas", CountryCode = "US", StarRating = 5},
                new Hotel{ Name = "Venetian", CityName = "Las Vegas", CountryCode = "US", StarRating = 4.5f },
                new Hotel{ Name = "Bellagio", CityName = "Las Vegas", CountryCode = "US", StarRating = 5 },
                new Hotel{ Name = "Mirage", CityName = "Las Vegas", CountryCode = "US", StarRating = 4 }
            };
        }
    }
}
