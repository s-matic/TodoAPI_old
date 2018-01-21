using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Models;

namespace API.Logic.Commands
{
    public class TodoCommands : ITodoCommands
    {
        public async Task<int> Save(TodoItem Item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> Delete(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}