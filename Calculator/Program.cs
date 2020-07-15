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
        string operation = Console.ReadLine();

        double result = 0;
        switch (operation)
        {
          case "1":
            result = GetNum1() + GetNum2();
            break;
          case "2":
            result = GetNum1() - GetNum2();
            break;
          case "3":
            result = GetNum1() * GetNum2();
            break;
          case "4":
            result = GetNum1() / GetNum2();
            break;
          default:
            stay = false;
            break;
        }
        System.Console.WriteLine("result: {0} \n", result);
      } while (stay);
    }
    static double GetNum1()
    {
      System.Console.Write("enter first num: ");
      var num1 = 1D;
      if (double.TryParse(Console.ReadLine(), out num1))
      { // tryparse will return a boolean
        System.Console.WriteLine("valid");
      }
      else
      {
        num1 = -1D;
        System.Console.WriteLine("digit not valid, providing default {0}", num1);
      }
      return num1;
    }
    static double GetNum2()
    {
      var num2 = -1D;
      System.Console.Write("enter second num: ");
      if (double.TryParse(Console.ReadLine(), out num2))
      {
        System.Console.WriteLine("valid");
      }
      else
      {
        num2 = -1D;
        System.Console.WriteLine("digit not valid, providing default {0}", num2);
      }
      return num2;
    }
  }
}
