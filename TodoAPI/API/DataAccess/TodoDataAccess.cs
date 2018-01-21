using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccess
{
    public class TodoDataAccess : ITodoDataAccess
    {
        private ITodoContext _todoContext;

        public TodoDataAccess(ITodoContext todoContext)
        {
            _todoContext = todoContext;
        }
        public async Task<IEnumerable<TodoItem>> Get()
        {
            return  _todoContext.TodoItems;
        }

        public async Task<TodoItem> Get(int Id)
        {
            return await _todoContext.TodoItems.Where(i => i.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<int> Save(TodoItem item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> Delete(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}