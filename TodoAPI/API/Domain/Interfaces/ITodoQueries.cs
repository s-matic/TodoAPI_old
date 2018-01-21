using System.Collections.Generic;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoQueries
    {
        IEnumerable<TodoItem> Get();
        TodoItem Get(int Id);        
    }
}