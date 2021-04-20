using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AutoCompleteSearchController : ControllerBase
    {

        private readonly ILogger<AutoCompleteSearchController> _logger;

        public AutoCompleteSearchController(ILogger<AutoCompleteSearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PersonCity> Get([FromQuery]string term)
        {
            // simulate a service call...
            var data = PersonCityData.Data.Where(s => s.FamilyName.StartsWith(term) || s.Name.StartsWith(term));
            return data;
        }
    }
}
