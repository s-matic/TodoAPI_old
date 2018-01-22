using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Models;

namespace API.Logic.Queries
{
    public class TodoQueries : ITodoQueries
    {
        private readonly ITodoDataAccess _todoDataAccess;

        public TodoQueries(ITodoDataAccess todoDataAccess)
        {
            _todoDataAccess = todoDataAccess;
        }
        public async Task<IEnumerable<TodoItem>> Get()
        {
            var result = await _todoDataAccess.Get();
            return result;
        }
        public async Task<TodoItem> Get(int Id)
        {
            var result = await _todoDataAccess.Get(Id);
            return result;
        }
    }
}