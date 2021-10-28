using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyBlazorWebApp.Models;

namespace FamilyBlazorWebApp.Data
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdults();
        Task AddAdult(Adult adult);
        Task RemoveAdult(int adultId);
        Task UpdateAdult(Adult adult);
        Task<Adult> Get(int adultId);
    }
}