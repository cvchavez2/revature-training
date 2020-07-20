using System.Collections.Generic;
using PizzaStore.Client;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
  public class StartupTests
  {
    [Fact]
    public void Test_CreateOrder()
    {
      // arrange
      var sut = new Startup();
      var user = new User();
      var store = new Store();
      
      // act
      var order = sut.CreateOrder(user, store);
      // assert
      Assert.True(order != null);
      Assert.NotNull(order);
    }
  }
}