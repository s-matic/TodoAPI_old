using System.Threading.Tasks;
using API.DataAccess;
using API.Logic.Commands;
using API.Logic.Queries;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.Tests.ControllerTests
{
    [TestClass]
    public class TodoCommandsTests
    {
        [TestMethod]
        [TestCategory("TodoCommandsTests")]
        public async Task Shoud_insert_todo_task()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "Shoud_insert_todo_task")
                .Options;
            
            var context = new TodoContext(options);
            var dataAccess = new TodoDataAccess(context);
            var todoCommands = new TodoCommands(dataAccess);
            int expected = 1;
            var newTodoItem = new TodoItem()
            {
                Completed = true,
                Title = "A title"
            };
            
            //Act
            var actual = await todoCommands.Save(newTodoItem);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("TodoCommandsTests")]
        public async Task Should_update_todo_task()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "Shoud_update_todo_task")
                .Options;
            
            var context = new TodoContext(options);
            var dataAccess = new TodoDataAccess(context);
            var todoCommands = new TodoCommands(dataAccess);
            
            var newTodoItem = new TodoItem()
            {
                Completed = true,
                Title = "A title"
            };
            
            int expected = 1;
            
            //Act
            context.TodoItems.Add(newTodoItem);
            context.SaveChanges();
            newTodoItem.Completed = false;
            newTodoItem.Title = "Updated title";
            var actual = await todoCommands.Save(newTodoItem);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("TodoCommandsTests")]
        public async Task Should_delete_todo_task()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "Shoud_update_todo_task")
                .Options;
            
            var context = new TodoContext(options);
            var dataAccess = new TodoDataAccess(context);
            var todoCommands = new TodoCommands(dataAccess);
            
            var newTodoItem = new TodoItem()
            {
                Completed = true,
                Title = "A title"
            };
            
            //Act
            context.TodoItems.Add(newTodoItem);
            context.SaveChanges();
            
        }
    }
}