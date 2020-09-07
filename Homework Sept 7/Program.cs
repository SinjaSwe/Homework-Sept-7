using System;

namespace Homework_Sept_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("How old are you?");
                          
            Console.ReadKey();

            int num = Convert.ToInt32(Console.ReadLine());

            if(num > 20)
            {
                Console.WriteLine("You are old enough to drink wine!");
            }

            else
            {
                Console.WriteLine("You are not old enought to drink wine!");
                    }
        }
    }
}
