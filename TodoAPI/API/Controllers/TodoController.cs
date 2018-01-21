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
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            throw new NotImplementedException();
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