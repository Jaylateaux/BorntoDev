using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int multiple = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(multiple + " x " + i + " = " + multiple*i);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
