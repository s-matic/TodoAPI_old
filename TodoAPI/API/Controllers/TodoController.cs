using System;
using System.Collections;
using System.Collections.Generic;
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
        public IEnumerable<TodoItem> Get()
        {
            var items = _todoQueries.Get();
            return items;
        }

        public TodoItem Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Post(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void Put(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }
}