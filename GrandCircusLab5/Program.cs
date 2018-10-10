using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* use recursion to create a factorial method
             * enter integer from 1 to 10
             * display factorial
             * prompt to continue
             */

            ulong factorial;
            string cont = "y";

            Console.WriteLine("Hello! If you're looking to calculate factorials, you've come to the right place!" +
                "\nAnd why would you not want to calculate factorials???\n");
                    

            while (cont == "y" || cont == "yes")
            {
                Console.Write("Enter an integer from 1 to 65 (that's the biggest integer this baby can handle): ");
                while (!ulong.TryParse(Console.ReadLine(), out factorial) || factorial < 0 || factorial > 65)
                {
                    if (factorial > 65)
                    {
                        Console.WriteLine("(If you're trying to find a factorial greater than 65, you're doing it wrong)");
                    }
                    else if (factorial < 0)
                    {
                        Console.WriteLine("(Please don't try to get the factorial of a negative number. It hurts my computer brain)");
                    }
                    Console.Write("That's not a valid entry. Please enter an integer from 1 to 65: ");
                }
                Console.WriteLine("\nThe factorial of " + factorial + " is " + GetFactorial(factorial));
                Console.Write("Would you like to continue? (y/n) ");
                cont = Console.ReadLine().ToLower();
                while (cont != "y" && cont != "n" && cont != "yes" && cont != "no")
                {
                    Console.Write("Come on, it's not that hard. Enter \"y\" for \"yes\" and \"n\" for \"no\": ");
                    cont = Console.ReadLine().ToLower();
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
        public static ulong GetFactorial(ulong x)
        {
            //recursive method

            if (x == 0)
                return 1;
            return x * GetFactorial(x - 1);

        }
    }
}
