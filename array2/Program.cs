using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHelloWorld10Times();
            Console.WriteLine(cal());
            Console.ReadLine();

            string[][] users = new string[5][];
            for (int i = 0; i < 5; i++)
            {
                users[i] = new string[3];
                Console.WriteLine("User No." + (i+1) );
                Console.Write("First Name : ");
                users[i][0] = Console.ReadLine();
                Console.Write("Last Name : ");
                users[i][1] = Console.ReadLine();
                Console.Write("Tel : ");
                users[i][2] = Console.ReadLine();
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("Result");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("User No. |      Name      |    Tel");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("    " + (i+1) + ".   " + users[i][0] + " " + users[i][1] + " | Tel : " + users[i][2]);
            }

            Console.ReadLine();
        }

        private static void sayHelloWorld10Times()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
        }

        private static int cal()
        {
            int a = 10;
            int b = 5;
            int sum = a + b;
            return sum;
        }

    }
}
