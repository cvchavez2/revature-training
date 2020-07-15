using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to our new calculator");
      var stay = true;
      do
      {
        System.Console.WriteLine("Menu");
        System.Console.WriteLine("1 for +");
        System.Console.WriteLine("2 for -");
        System.Console.WriteLine("3 for *");
        System.Console.WriteLine("4 for /");
        System.Console.Write("enter operation: ");
        var operation = Console.ReadLine();

        var result = 0D;
        switch (operation)
        {
          case "1":
            result = GetNum("first") + GetNum("second");
            break;
          case "2":
            result = GetNum("first") + GetNum("second");
            break;
          case "3":
            result = GetNum("first") + GetNum("second");
            break;
          case "4":
            result = GetNum("first") + GetNum("second");
            break;
          default:
            stay = false;
            break;
        }
        System.Console.WriteLine("result: {0} \n", result);
      } while (stay);
    }
    static double GetNum(string s)
    {
      var isValid = true;
      double num1;
      do
      {
        System.Console.Write("enter {0} num: ", s);
        if (double.TryParse(Console.ReadLine(), out num1))
        { 
          System.Console.WriteLine("valid");
        }
        else
        {
          System.Console.WriteLine("value not valid, provide valid value");
          isValid = false;
        }
      } while (!isValid);
      return num1;
    }
  }
}
