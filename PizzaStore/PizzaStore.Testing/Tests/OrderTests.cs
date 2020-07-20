using System.Collections.Generic;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
  public class OrderTest
  {
    [Theory]
    [InlineData("S","T","C")]
    public void Test_CreatePizza(string s, string t, string c)
    {
      // arrange
      var sut = new Order();
      string size = s;
      List<string> toppings = new List<string>{t};
      string crust = c;
      
      // act
      sut.CreatePizza("",size,toppings,crust);
      // assert
      Assert.True(sut.Pizzas.Count == 1);
    }
  }
}

// when adding a xunit test
// create a new project using dotnet new xunit -n PizzaStore.Testing
// added to your solution dotnet sln add **/*.csproj
// add your tests directory
// add your test class
// now reference your Testing class to Domain dotnet add PizzaStore.Testing/PizzaStore.Testing.csproj reference PizzaStore.Domain/PizzaStore.Domain.csproj

// Go to command palette
// Debug -> assets and build (this will create the .vscode doc)
// In launch.json change console “integratedTerminal”