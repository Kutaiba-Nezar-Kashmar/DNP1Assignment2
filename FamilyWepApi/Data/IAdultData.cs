using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWepApi.Models;

namespace FamilyWepApi.Data
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdults();
        Task<Adult> AddAdult(Adult adult);
        Task RemoveAdult(int adultId);
        Task<Adult> UpdateAdult(Adult adult);
        Task<Adult> Get(int adultId);
    }
}