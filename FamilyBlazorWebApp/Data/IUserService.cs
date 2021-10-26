using FamilyBlazorWebApp.Models;

namespace FamilyBlazorWebApp.Data
{
    public interface IUserService
    {
        void CreateUser(User user);
        User ValidateUser(string userName, string password);
    }
}