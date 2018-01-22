using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DataAccess;
using API.Logic.Queries;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.Tests.ControllerTests
{
    [TestClass]
    public class TodoQueriesTests
    {
        [TestMethod]
        [TestCategory("TodoQueriesTests")]
        public async Task Should_return_empty_list_of_todo_items()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "Should_return_empty_list_of_todo_items")
                .Options;
            
            var context = new TodoContext(options);
            var dataAccess = new TodoDataAccess(context);
            var todoQueries = new TodoQueries(dataAccess);
            
            List<TodoItem> expected = new List<TodoItem>();
            
            //Act
            var actual = await todoQueries.Get();
            
            //Assert
            Assert.AreEqual(expected.GetType(), actual.ToList().GetType());
        }

        [TestMethod]
        [TestCategory("TodoQueriesTests")]
        public async Task Should_return_one_todo_item()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "Should_return_one_todo_item")
                .Options;
            
            var context = new TodoContext(options);      
            var dataAccess = new TodoDataAccess(context);
            var todoQueries = new TodoQueries(dataAccess);
            
            var expected = new TodoItem(){Completed = false, Title = "Test"};
            context.TodoItems.Add(expected);
            context.SaveChanges();
            int id = expected.Id;  
            
            //Act
            var actual = await todoQueries.Get(id);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}