using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Hello " + count);
                count++;
            }
            while (count < 10);
            Console.ReadLine();
        }
    }
}
