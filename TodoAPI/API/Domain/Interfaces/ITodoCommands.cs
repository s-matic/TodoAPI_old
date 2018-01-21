using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoCommands
    {
        int Save(TodoItem Item);
        int Delete(int Id);
    }
}