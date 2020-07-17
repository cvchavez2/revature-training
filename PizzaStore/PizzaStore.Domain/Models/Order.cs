using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { get; set; }
    public void CreatePizza(string imageUrl, string size, List<string> toppings, string crust)
    {
      // var pizza = new Pizza(imageUrl, size, toppings, crust);

      // pizza.imageUrl = imageUrl;
      // pizza.size = size;
      // pizza.crust = crust;
      // pizza.toppings.AddRange(toppings); // AddRange will get the content reference by toppings and add them to the new pizza

      Pizzas.Add(new Pizza(imageUrl, size, toppings, crust));
    }

    public Order()
    {
      Pizzas = new List<Pizza>();
    }
  }
}