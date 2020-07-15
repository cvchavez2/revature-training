using C = System.Console;

namespace HelloCsharp{
  class Program{ // good practice is to match the name with the name of the file - Program as for Program.cs
    static void Main(string [] args){
      C.Write("Enter your name: ");
      var name = C.ReadLine();  // lazy instantiation 
      C.Write("Enter last name: ");
      string input = C.ReadLine(); // eager, datatype is explicit prior to content of Readline
      C.WriteLine("name entered is: " + name);
      C.WriteLine("{0} {1}", name, input);
      C.WriteLine($"{name} is my name, This, {input}, my last name."); // interpolation
    }
  }
}
// ///////////////////////////////////////////////////////////////////////////
// using System; using is not an importer
// or
// using c = System.Console; // alias

// namespace HelloCsharp // directory, by convention you want your namespace to match your project structure

// {
//     class Program
//     {
//         static void Main(string[] args) // PascalCasing, Main is keyword, main is not
//         {
//             c.WriteLine("hello Carlos"); // fully qualified name
//             HelloCsharp.Program.Test();
//         }
//         static void Test(){
//           c.WriteLine("test method");
//         }
//     }
// }

// namespace System{
//   class Console{
//     void WriteLine(){

//     }
//   }
// }
