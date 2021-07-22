using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] country = { "Thailand", "Laos", "Singapore", "USA", "UK" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(country[i]);
            }
            Console.WriteLine("---------");
            foreach (string data in country)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
