using System.Threading.Tasks;
using EasyAuto.API.Models;
using Framework.Common.Helpers;

namespace EasyAuto.API.ExternalApi
{
    public interface IVehicleApi
    {
        Task<ResultItem<VehicleMakeResult>> GetMakesAsync(string search);
    }
}
