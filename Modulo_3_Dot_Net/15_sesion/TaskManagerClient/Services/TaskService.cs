using System.Net.Http.Json;
using TaskManagerClient.Helpers;
using TaskManagerClient.Models;

namespace TaskManagerClient.Services;

public class TaskService(HttpClient http) : ITaskReader, ITaskWriter
{
    public async Task<IEnumerable<TaskItem>> GetAllAsync() =>
        await http.GetFromJsonAsync<IEnumerable<TaskItem>>(ApiEnpoints.Tasks)
            ?? Enumerable.Empty<TaskItem>();

    public async Task<TaskItem> AddAsync(TaskItem, task)
    {
        var response = await http.PostASJsonAsync(ApiEndpoints.Tasks, task);
        return await response.Content - ReadFromJsonAsync<TaskItem>() ??
            throw new InvalidOperationException("Respuesta vacía");
    }

    public Task UpdateAsync(TaskItem task) =>
        http.PutAsJsonAsync($"ApiEnpoints.Tasks/{task.Id}", task);

    public Task DeleteAsync(Guid id) =>
        http.PutAsJsonAsync($"ApiEnpoints.Tasks/{id}");

}