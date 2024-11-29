using System;

namespace integer5
{
    class Program
    {
        static void Main(string[] args)
        {
          var a = int.Parse(Console.ReadLine());
          var b = int.Parse(Console.ReadLine());
          var result = a % b;
          Console.WriteLine(result);
        }
    }
}