using System;
using System.Collections.Generic;

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
      List<string> cart = new List<string>();
      Menu2(cart);
    }
    static void Menu(string[] cart)
    {
      int number = 0;
      var exit = false;
      do
      {
        if (number == cart.Length)
        {
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
      } while (!exit);
    }
    static void Menu2(List<string> cart)
    {
      var exit = false;
      do
      {
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
            cart.Add("cheese");
            break;
          case 2:
            System.Console.WriteLine("added Pepperoni Pizza");
            cart.Add("pepperoni");
            break;
          case 3:
            System.Console.WriteLine("added Hawaiian Pizza");
            cart.Add("hawaiian");
            break;
          case 4: 
            System.Console.WriteLine("added Custom");
            cart.Add("custom");
            break;
          case 5:
            System.Console.WriteLine("show Cart");
            DisplayCart2(cart);
            break;
          case 6:
            System.Console.WriteLine("exit menu, thank you");
            exit = true;
            break;            
        }
      } while (!exit);
    }
    static void DisplayCart(string[] cart)
    {
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }
    static void DisplayCart2(List<string> cart)
    {
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }
  }
}
