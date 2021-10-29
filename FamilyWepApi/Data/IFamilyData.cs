using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWepApi.Models;

namespace FamilyWepApi.Data
{
    public interface IFamilyData
    {
        Task<IList<Family>> GetFamilies();
        Task<Family> AddFamily(Family family);
        Task RemoveFamily(int familyId);
        Task<Family> UpdateFamily(Family family);
        Task<Family> Get(int familyId);
    }
}