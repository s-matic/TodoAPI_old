using System.Collections.Generic;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoController
    {
        IEnumerable<TodoItem> Get();
        TodoItem Get(int Id);
        void Post(TodoItem item);
        void Put(TodoItem item);
        void Delete(int Id);
    }
}