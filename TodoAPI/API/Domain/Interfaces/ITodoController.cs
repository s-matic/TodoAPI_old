﻿using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Domain.Interfaces
{
    public interface ITodoController
    {
        Task<IEnumerable<TodoItem>> Get();
        Task<TodoItem> Get(int Id);
        Task Post(TodoItem item);
        Task Put(TodoItem item);
        Task Delete(int Id);
    }
}