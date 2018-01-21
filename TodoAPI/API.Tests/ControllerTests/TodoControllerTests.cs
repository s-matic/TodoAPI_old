using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using API.Controllers;
using API.DataAccess;
using API.Logic.Commands;
using API.Logic.Queries;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.Tests.ControllerTests
{
    [TestClass]
    public class TodoControllerTests
    {
        private readonly TodoController _todoController;

        public TodoControllerTests()
        {
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "TodoQueriesTests")
                .Options;
            
            var context = new TodoContext(options);
            var dataAccess = new TodoDataAccess(context);
            var queries = new TodoQueries(dataAccess);
            var commands = new TodoCommands();
            
            _todoController = new TodoController(queries, commands);
        }

        [TestMethod]
        [TestCategory("TodoControllerTests")]
        public async Task Should_return_empty_list_of_todo_items()
        {
            //Arrange
            int expected = 0;
            
            //Act
            var result = await _todoController.Get();
            
            //Assert
            Assert.AreEqual(result.ToList().Count, expected);
        }
        
    }
}