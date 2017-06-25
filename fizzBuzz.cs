using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(50, 80);
            Console.ReadKey();
        }

        static void FizzBuzz(int number, int number2)
        {
            
            for(int i = number; number <= number2; number++)
            {
                if (number % 5 == 0 && number % 3 == 0) 
                {
                    Console.Write("Fizz");
                    Console.ReadKey();
                }
                else if (number % 3 == 0)
                {
                    Console.Write("Buzz");
                    Console.ReadKey();
                }
                else if(number % 5 == 0)                {
                    Console.Write("FizzBuzz");
                    Console.ReadKey(); 
                }


            }
         }
    }

}
