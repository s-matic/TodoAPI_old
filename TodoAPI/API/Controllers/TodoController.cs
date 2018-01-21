using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller, ITodoController
    {
        private readonly ITodoQueries _todoQueries;
        private readonly ITodoCommands _todoCommands;

        public TodoController(ITodoQueries todoQueries, ITodoCommands todoCommands)
        {
            _todoQueries = todoQueries;
            _todoCommands = todoCommands;
        }
        [HttpGet]
        public async Task<IEnumerable<TodoItem>> Get()
        {
            var items = await _todoQueries.Get();
            return items;
        }

        public Task<TodoItem> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Post(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task Put(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }
}