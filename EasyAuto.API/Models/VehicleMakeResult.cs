using System.Collections.Generic;

namespace EasyAuto.API.Models
{
    public class VehicleMakeResult
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public IEnumerable<VehicleMake> Results { get; set; }
    }
}
