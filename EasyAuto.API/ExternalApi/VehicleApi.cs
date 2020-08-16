using System.Net.Http;
using System.Threading.Tasks;
using EasyAuto.API.Models;
using Framework.Common.Helpers;
using Newtonsoft.Json;

namespace EasyAuto.API.ExternalApi
{
    public class VehicleApi : IVehicleApi
    {
        private readonly HttpClient _client;
        public VehicleApi(HttpClient client)
        {
            _client = client;
        }

        public async Task<ResultItem<VehicleMakeResult>> GetMakesAsync (string search)
        {
            var response = await _client.GetAsync($"/api/vehicles/getallmakes?format=json");
            if (response.IsSuccessStatusCode)
            {
                //var resultTemp = await response.Content.ReadAsJsonAsync<VehicleMakeResult>();
                
                // Works
                var resp = JsonConvert.DeserializeObject<VehicleMakeResult>(await response.Content.ReadAsStringAsync());
                return new ResultItem<VehicleMakeResult>(resp);
                
            }
            // Handle Error
            return null;
        }
    }
}
