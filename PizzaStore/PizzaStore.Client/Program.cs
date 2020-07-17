using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }
    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld");
      System.Console.WriteLine("Best Pizza in the World");
      System.Console.WriteLine();

      // string[] cart = new string[3];
      // List<Pizza> cart = new List<Pizza>();
      // Menu2(cart);

      //////////////////////////
      var startup = new Startup();
      var user = new User();
      var store = new Store();

      // var order = startup.CreateOrder(user, store);
      // if(order!=null){
      //   Menu3(order);
      // }else{
      //   System.Console.WriteLine("technical difficulties");
      // }

      try{
        Menu3(startup.CreateOrder(user, store));
      }
      catch(Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }

    }
    static void Menu(string[] cart)
    {
      int number = 0;
      var exit = false;
      do
      {
        if (number == cart.Length)
        {
          System.Console.WriteLine("Your cart reached maximum allowed number of pizzas!");
          exit = true;
          continue;
        }
        System.Console.WriteLine("Select 1 for Cheese Pizza");
        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
        System.Console.WriteLine("Select 3 for Hawaian Pizza");
        System.Console.WriteLine("Select 4 for Custom Pizza");
        System.Console.WriteLine("Select 5 to show Cart");
        System.Console.WriteLine("Select 6 to Exit");
        System.Console.WriteLine();

        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            System.Console.WriteLine("added Cheese Pizza");
            cart[number] = "cheese";
            number += 1;
            break;
          case 2:
            System.Console.WriteLine("added Pepperoni Pizza");
            cart[number] = "pepperoni";
            number += 1;
            break;
          case 3:
            System.Console.WriteLine("added Hawaiian Pizza");
            cart[number] = "hawaiian";
            number += 1;
            break;
          case 4:
            System.Console.WriteLine("added Custom");
            cart[number] = "custom";
            number += 1;
            break;
          case 5:
            System.Console.WriteLine("show Cart");
            DisplayCart(cart);
            break;
          case 6:
            System.Console.WriteLine("exit menu, thank you");
            exit = true;
            break;
        }
        System.Console.WriteLine();
      } while (!exit);
    }
    // static void Menu2(List<Pizza> cart)
    // {
    //   var exit = false;
    //   var startup = new PizzaStore.Client.Startup();
    //   do
    //   {
    //     System.Console.WriteLine("Select 1 for Cheese Pizza");
    //     System.Console.WriteLine("Select 2 for Pepperoni Pizza");
    //     System.Console.WriteLine("Select 3 for Hawaian Pizza");
    //     System.Console.WriteLine("Select 4 for Custom Pizza");
    //     System.Console.WriteLine("Select 5 to show Cart");
    //     System.Console.WriteLine("Select 6 to Exit");
    //     System.Console.WriteLine();

    //     int select;
    //     int.TryParse(Console.ReadLine(), out select);

    //     switch (select)
    //     {
    //       case 1:
    //         var pzz = startup.CreatePizza("unknown","L","stuffed", new List<string>{"ran","jal"});
    //         cart.Add(pzz);
    //         System.Console.WriteLine("added Cheese Pizza");
    //         break;
    //       case 2:
    //         cart.Add(startup.CreatePizza("unknown","L","stuffed", new List<string>{"1","2"}));
    //         System.Console.WriteLine("added Pepperoni Pizza");
    //         break;
    //       case 3:
    //         cart.Add(startup.CreatePizza("unknown","L","stuffed", new List<string>{"1","2"}));
    //         System.Console.WriteLine("added Hawaiian Pizza");
    //         break;
    //       case 4: 
    //         cart.Add(startup.CreatePizza("unknown","L","stuffed", new List<string>{"1","2"}));
    //         System.Console.WriteLine("added Custom");
    //         break;
    //       case 5:
    //         System.Console.WriteLine("Cart\n");
    //         DisplayCart2(cart);
    //         break;
    //       case 6:
    //         System.Console.WriteLine("exit menu, thank you");
    //         exit = true;
    //         break;            
    //     }
    //     System.Console.WriteLine();
    //   } while (!exit);
    // }
    static void DisplayCart(string[] cart)
    {
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }
    static void DisplayCart2(List<Pizza> cart)
    {
      int counter = 1;
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(counter++ + ". " + pizza);
      }
    }
    static void Menu3(Order cart)
    {
      var exit = false;
      // var startup = new PizzaStore.Client.Startup();
      do
      {
        Startup.PrintMenu();
        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.CreatePizza("unknown", "L", new List<string> { "ran", "jal" }, "stuffed" );
            System.Console.WriteLine("added Cheese Pizza");
            break;
          case 2:
            cart.CreatePizza("unknown", "L", new List<string> { "ran", "jal" }, "stuffed");
            System.Console.WriteLine("added Pepperoni Pizza");
            break;
          case 3:
            cart.CreatePizza("unknown", "L", new List<string> { "ran", "jal" }, "stuffed");
            System.Console.WriteLine("added Hawaiian Pizza");
            break;
          case 4:
            cart.CreatePizza("unknown", "L", new List<string> { "ran", "jal" }, "stuffed");
            System.Console.WriteLine("added Custom");
            break;
          case 5:
            System.Console.WriteLine("Cart\n");
            DisplayCart3(cart);
            break;
          case 6:
            System.Console.WriteLine("exit menu, thank you");
            exit = true;
            break;
        }
        System.Console.WriteLine();
      } while (!exit);
    }
    static void DisplayCart3(Order cart)
    {
      int counter = 1;
      foreach (var pizza in cart.Pizzas)
      {
        System.Console.WriteLine(counter++ + ". " + pizza);
      }
    }
  }
}
