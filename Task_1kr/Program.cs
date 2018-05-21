using System;

namespace Task_1kr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");
            Random random = new Random();
            for(int i = 1; i < random.Next(5, 50); i++)
            {
                Console.Write("!");
            }
        }
    }
}
