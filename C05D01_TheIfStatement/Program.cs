using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05D01_TheIfStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers (on separate lines).");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;
            if (secondNumber > firstNumber) ;
            {
                biggerNumber = secondNumber;
            }

            Console.WriteLine("The bigger number is: {0}", biggerNumber);
            Console.ReadLine();
        }
    }
}
