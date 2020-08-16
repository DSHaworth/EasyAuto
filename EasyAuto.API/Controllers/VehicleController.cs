using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyAuto.API.ExternalApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyAuto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleApi _client;

        public VehicleController(IVehicleApi client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string query)
        {
            var response = await _client.GetMakesAsync(query);

            // Do something with response

            return Ok(response.Item);
        }
    }
}
