using System;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  public class Startup
  {
    public Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();

        user.Orders.Add(order);
        store.Orders.Add(order);

        return order;
      }
      catch
      {
        // return null;
        throw new System.Exception();
      }
      finally{
        GC.Collect();
      }
    }
    internal static void PrintMenu()
    {
        System.Console.WriteLine("Select 1 for Cheese Pizza");
        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
        System.Console.WriteLine("Select 3 for Hawaian Pizza");
        System.Console.WriteLine("Select 4 for Custom Pizza");
        System.Console.WriteLine("Select 5 to show Cart");
        System.Console.WriteLine("Select 6 to Exit");
        System.Console.WriteLine("Select 7 to Read File");
        System.Console.WriteLine();
    }
  }
}