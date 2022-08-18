using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage3._0.Web.Services
{
    public interface IMemberShipSelectListService
    {
        Task<IEnumerable<SelectListItem>> GetVehicleTypesAsync();
    }

}
