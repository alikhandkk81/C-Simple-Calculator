using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            string answer;

            Console.WriteLine("Hello, Welcome to the Calculator program");
            
            Console.WriteLine("Plz Enter Your first Number.");
            
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Plz Enter Your first Number.");
           
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do.");
            
            Console.WriteLine("Plz enter a for addition, s for subtraction, m for multiplication or d for divition.");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num1 / num2;
            }
            else 
            {
                Console.WriteLine("Wrong input");
            }

            Console.WriteLine("The Result is: "+ result);

            Console.WriteLine("Thank you for using the Calculator Program!");
            
            Console.ReadKey();
        }
    }
}
