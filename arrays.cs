using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;   // not a good way to do array - lengthy
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.ReadLine();
        }

        */
            //six items this time
            // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            

             string[] names = new string[] { "Billy", "Bob", "Bear", "Big Jilm" };

            /*
            for (int i = 0; i < names.Length; i++)  //this means it cycles thru names the 'Length' of the array or all array values or in this case all names in the string array  
             {
                 Console.WriteLine(names[i]);
             }
             Console.ReadLine();*/

            /*
            foreach (string name in names )
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();*/

            string zman = "hey dude";
            char[] charArray = zman.ToCharArray();  // ToCharArray is an operator; charArray is our operand name for the array
            Array.Reverse(charArray);
            foreach (char zmanChar in charArray)
            {
                Console.Write(zmanChar);
            }
                Console.ReadLine();
                }
    }
}
