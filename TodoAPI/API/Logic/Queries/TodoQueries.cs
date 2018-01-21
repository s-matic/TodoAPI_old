using System.Collections.Generic;
using API.Domain.Interfaces;
using API.Models;

namespace API.Logic.Queries
{
    public class TodoQueries : ITodoQueries
    {
        public IEnumerable<TodoItem> Get()
        {
            throw new System.NotImplementedException();
        }

        public TodoItem Get(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}