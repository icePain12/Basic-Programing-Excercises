/* In This program we will show the hello world but in a method in order to get used to how objet oriented programming works */
using System;
namespace Hello
{
    class Program
    {
        static void Main(String[] args)
        {
            // This method will put in blank your console when the program starts.
            Console.Clear();
            // This Line is Optional It will put your console in Green.
             Console.ForegroundColor = ConsoleColor.Green;
            // Whe call the method "Salute" in order to Run what it does. That is to print: "Hello World" in your console.
             Salute();
             Console.ReadKey();   
        }
        // we declare a method call Salute to run the hello world program.
        static void Salute()
        {
              Console.Write("Hello World...");
        }
    }
}
