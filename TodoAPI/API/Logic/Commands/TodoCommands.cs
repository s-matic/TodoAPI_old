using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Models;

namespace API.Logic.Commands
{
    public class TodoCommands : ITodoCommands
    {
        private ITodoDataAccess _todoDataAccess;

        public TodoCommands(ITodoDataAccess todoDataAccess)
        {
            _todoDataAccess = todoDataAccess;
        }
        public async Task<int> Save(TodoItem item)
        {
            var result = await _todoDataAccess.Save(item);
            return result;
        }

        public async Task<int> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}