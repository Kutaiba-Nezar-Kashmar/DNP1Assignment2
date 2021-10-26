using System.Collections.Generic;
using FamilyBlazorWebApp.Models;

namespace FamilyBlazorWebApp.Data
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