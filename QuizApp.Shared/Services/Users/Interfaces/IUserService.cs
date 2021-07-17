using QuizApp.Shared.Entities.Users;
using System;
using System.Threading.Tasks;

namespace QuizApp.Shared.Services.Users.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser[]> GetAsync();
        Task<ApplicationUser> GetAsync(Guid id);
        Task<ApplicationUser> GetAsync(string username, string password);
        Task<(bool succeeded, string message)> AddAsync(ApplicationUser user);
        Task<(bool succeeded, string message)> UpdateAsync(ApplicationUser user);
        Task<(bool succeeded, string message)> DeleteAsync(Guid id);
    }
}