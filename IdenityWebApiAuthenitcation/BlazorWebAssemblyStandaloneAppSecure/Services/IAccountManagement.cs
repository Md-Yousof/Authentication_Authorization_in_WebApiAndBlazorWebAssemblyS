using BlazorWebAssemblyStandaloneAppSecure.Model;
using System.Data;

namespace BlazorWebAssemblyStandaloneAppSecure.Services
{
    public interface IAccountManagement
    {
        public Task<FormResult> RegisterAsync(string email, string password);

        public Task<FormResult> LoginAsync(string email, string password);

        public Task LogoutAsync();

        public Task<bool> CheckAuthenticateAsync();


        public Task<List<Role>> GetRoles();

        public Task<FormResult> AddRole(string[] roles);

        public Task<UserViewModel[]> GetUsers();

        public Task<UserViewModel> GetUserByEmail(string userEmailId);

        public Task<bool> UserUpdate(string userEmailId, UserViewModel user);

        public Task<bool> Delete(string userEmailId);
    }
}
