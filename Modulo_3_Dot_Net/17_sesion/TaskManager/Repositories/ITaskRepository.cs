using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task AddAsync(TaskItem taskItem);
        Task<TaskItem?> GetAsync(Guid id);
        Task<bool> UpdateAsync(TaskItem taskItem);
        Task<bool> DeleteAsync(Guid id);
    }
}