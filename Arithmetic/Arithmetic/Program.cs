using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    static class Program
    {
        public static void Main(String[] args)
        {
            int number1; // declare first number to add
            int number2=1; // declare second number to add
            int sum; // 
            int diff; //
            int mult; //
            int quo=1; //
            Console.Write("Enter first integer: "); // prompt user and read first number
           number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); // prompt user and read first number      
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
                Console.WriteLine("sum is {0}", sum);

                diff = number1 - number2;
                Console.WriteLine("diff is {0}", diff);

                mult = number1 * number2;
                Console.WriteLine("mult is {0}", mult);

                quo = number1 / number2;
                Console.WriteLine("div is {0}", quo);

        } // end Main
    } //end Class Arithmetic
}
