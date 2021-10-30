using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWepApi.Models;

namespace FamilyWepApi.Data
{
    public interface IUserData
    {
        Task<User> CreateUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}