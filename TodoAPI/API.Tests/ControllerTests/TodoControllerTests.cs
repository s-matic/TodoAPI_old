using System.Collections.Generic;
using System.Linq;
using System.Threading;
using API.Controllers;
using API.Logic.Commands;
using API.Logic.Queries;
using API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.Tests.ControllerTests
{
    [TestClass]
    public class TodoControllerTests
    {
        private TodoController _todoController;

        public TodoControllerTests()
        {
            _todoController = new TodoController(new TodoQueries(), new TodoCommands());
        }

        [TestMethod]
        [TestCategory("TodoControllerTests")]
        public void Should_return_list_of_todo_items()
        {
            //Arrange
            List<TodoItem> result;
            int expected = 1;
            
            //Act
            result = _todoController.Get().ToList();
            
            //Assert
            Assert.AreEqual(result.Count, expected);
        }
        
    }
}