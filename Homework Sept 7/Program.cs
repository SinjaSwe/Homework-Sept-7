using System;

namespace Homework_Sept_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("How old are you?");

            int numberOne = Convert.ToInt32(Console.ReadLine());
            
            string response = (numberOne > 20)      ? "You are allowed to drink beer" 
                                                    : "You are not allowed to drink beer! Welcome to the club!";  

            Console.WriteLine(response);
            Console.ReadKey();



        }

    }
}




