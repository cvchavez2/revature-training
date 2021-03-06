// using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // fields
    // private readonly string _imageUrl = "";
    // string Size = "";
    // string _imageUrl = "";
    List<string> _toppings = new List<string>();

    // properties same as mutarors and accessors
    public string ImageUrl { get; }
    public string Size { get; }
    public List<string> Toppings
    {
      get
      {
        return _toppings; // backing file
      }
    }
    public string Crust{get; }

    // methods
    void AddToppings(string topping)
    {
      Toppings.Add(topping);
    }
    public override string ToString()
    {
      var sb = new StringBuilder();
      foreach (var t in Toppings)
      {
        sb.Append(t + " ");
      }
      // return $"pizzaurl: {imageUrl} \nsize: {size} \ntoppings: {String.Join(", ",toppings)} \ncrust: {crust}";
      // or
      return $"pizzaurl: {ImageUrl} \nsize: {Size} \ntoppings: {sb} \ncrust: {Crust}";
    }

    // constructors
    public Pizza(string imageUrl, string size, List<string> toppings, string crust)
    {
      // System.Console.WriteLine("TEST" + imageUrl);
      ImageUrl = imageUrl;
      Size = size;
      Toppings.AddRange(toppings);
      Crust = crust;

    }
    public Pizza()
    {

    }
    // finalizers or destructors
  }
}