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
            if (item.Id == 0)
                return await Insert(item);
            
            return await Update(item);
        }

        private async Task<int> Update(TodoItem item)
        {
            _todoContext.TodoItems.Update(item);
            return await _todoContext.SaveChangesAsync();
        }

        private async Task<int> Insert(TodoItem item)
        {
            await _todoContext.TodoItems.AddAsync(item);
            return await _todoContext.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}