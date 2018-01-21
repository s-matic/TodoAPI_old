using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoDataAccess
    {
        Task<IEnumerable<TodoItem>> Get();
        Task<TodoItem> Get(int Id);
        Task<int> Save(TodoItem item);
        Task<int> Delete(int Id);
    }
}