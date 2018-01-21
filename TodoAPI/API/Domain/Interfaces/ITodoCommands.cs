using System.Threading.Tasks;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoCommands
    {
        Task<int> Save(TodoItem Item);
        Task<int> Delete(int Id);
    }
}