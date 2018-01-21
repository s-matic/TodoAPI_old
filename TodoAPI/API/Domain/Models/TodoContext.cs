using API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class TodoContext : DbContext, ITodoContext
    {
        public TodoContext()
        {
            
        }

        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
            
        }
        
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=Data/todo.db");
        }
    }
}