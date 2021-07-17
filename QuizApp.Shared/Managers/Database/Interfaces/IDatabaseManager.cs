using QuizApp.Shared.Entities.Interfaces;
using System;
using System.Threading.Tasks;

namespace QuizApp.Shared.Managers.Database.Interfaces
{
    public interface IDatabaseManager<T> where T : IEntity
    {
        Task<T[]> GetAsync();
        Task<T> GetAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> SaveAsync(T entity);
        Task<T> DeleteAsync(Guid id);
    }
}