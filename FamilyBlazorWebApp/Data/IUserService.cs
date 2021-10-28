using System.Threading.Tasks;
using FamilyBlazorWebApp.Models;

namespace FamilyBlazorWebApp.Data
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}