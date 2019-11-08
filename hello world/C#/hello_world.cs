using System;
namespace Hello
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
             Console.ForegroundColor = ConsoleColor.Green;
             Saludar();
             Console.ReadKey();   
        }
        static void Saludar()
        {
              Console.Write("Hello World...");
        }
    }
}