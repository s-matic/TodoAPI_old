using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Domain.Interfaces
{
    public interface ITodoContext
    {
        DbSet<TodoItem> TodoItems { get; set; }
    }
}