using System.Collections.Generic;
using FamilyWepApi.Models;

namespace FamilyWepApi.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void UpdateAdult(Adult adult);
        Adult Get(int adultId);
    }
}