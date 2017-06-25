using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Man
{
    class Program
    {
        /* static void Main(string[] args)
         {
             HelloWorld();
             Console.ReadLine();

         }


         private static void HelloWorld()
         {
             Console.WriteLine("Hello World!");
         }*/




                //Console.Write(Results: ); move this to the write area below
           // string reversedFirstName = ReverseString(firstName); We can get rid of all this with the code below
           // string reversedLastName = ReverseString(lastName);
           // string reversedCity = ReverseString(city);

                DisplayResult(
                    ReverseString(firstName),
                    ReverseString(lastName),
                    ReverseString(city));

    }

    /*  private static void ReverseString(string message)
    {

      char[] messageArray = message.ToCharArray();
      Array.Reverse(messageArray);
      foreach(char item in messageArray)
      {
          Console.Write(item);
      }

      Console.Write(" "); 
    }
     */
     {
          /*   Console.Write("Results: ");
                string reversedFirstName = ReverseString(firstName);
                string reversedLastName = ReverseString(lastName);
                string reversedCity = ReverseString(city);*/


           


    private static string ReverseString(string message)  //notice we are asking to return a string- not void.
    {

        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return string.Concat(messageArray);

    }
   


      {
             private static void DisplayResult(
                 string reversedFirstName,
                 string reversedLastName,
                 string reversedCity);

            Console.Write(Results: ");  

            Console.Write(string.format("{0}, {1}, {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));

            Console.ReadLine();

      {

                Console.Write


      }
   


}


   





}
