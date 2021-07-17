using QuizApp.Shared.Entities.Users;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using QuizApp.Shared.Services.Users.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Shared.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IDatabaseManager<ApplicationUser> _database;

        public UserService()
            => _database = new DatabaseManager<ApplicationUser>();

        public async Task<ApplicationUser[]> GetAsync()
        {
            try
            {
                return await _database.GetAsync();
            }
            catch
            {
                return null;
            }
        }

        public Task<ApplicationUser> GetAsync(Guid id)
        {
            try
            {
                return _database.GetAsync(id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<ApplicationUser> GetAsync(string username, string password)
        {
            var users = await GetAsync();

            return (users == null || !users.Any()) ? null : users.FirstOrDefault(user
                => user.Username.Equals(username) && user.Password.Equals(password));
        }

        public async Task<(bool succeeded, string message)> AddAsync(ApplicationUser user)
        {
            try
            {
                if ((await GetAsync(user.Username, user.Password)) != null)
                    return (false, "This user already exists!");

                await _database.AddAsync(user);
                return (true, "User added successfully!");
            }
            catch
            {
                return (false, "An unexpected error occurred while adding the user!");
            }
        }

        public async Task<(bool succeeded, string message)> UpdateAsync(ApplicationUser user)
        {
            try
            {
                return (await _database.UpdateAsync(user)) == null ?
                    (false, "Could not update information because user record not found!") :
                    (true, "User information has been successfully updated!");
            }
            catch
            {
                return (false, "An unexpected error occurred while updating user information!");
            }
        }

        public async Task<(bool succeeded, string message)> DeleteAsync(Guid id)
        {
            try
            {
                return (await _database.DeleteAsync(id)) == null ?
                    (false, "User record not deleted because not found!") :
                    (true, "User record deleted successfully!");
            }
            catch
            {
                return (false, "An unexpected error occurred while deleting the user record!");
            }
        }
    }
}