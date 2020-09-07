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

            int numberOne = Convert.ToInt32(Console.ReadLine());
            
            int response = (numberOne > 20)     ? "You are allowed to drink beer" 
                                                : "You are not allowed to drink beer";

            

          
        }
    }



