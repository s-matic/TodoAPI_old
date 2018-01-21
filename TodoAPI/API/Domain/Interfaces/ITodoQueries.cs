using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoQueries
    {
        Task<IEnumerable<TodoItem>> Get();
        Task<TodoItem> Get(int Id);        
    }
}