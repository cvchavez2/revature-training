// using System; using is not an importer
// or
using c = System.Console; // alias

namespace HelloCsharp // directory, by convention you want your namespace to match your project structure

{
    class Program
    {
        static void Main(string[] args) // PascalCasing, Main is keyword, main is not
        {
            c.WriteLine("hello Carlos"); // fully qualified name
            HelloCsharp.Program.Test();
        }
        static void Test(){
          c.WriteLine("test method");
        }
    }
}

// namespace System{
//   class Console{
//     void WriteLine(){

//     }
//   }
// }
