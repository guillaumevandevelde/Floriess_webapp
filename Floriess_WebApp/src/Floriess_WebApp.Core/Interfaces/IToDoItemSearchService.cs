using Ardalis.Result;
using Floriess_WebApp.Core.ProjectAggregate;

namespace Floriess_WebApp.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}