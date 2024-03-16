using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exception = errors that occur during execution
            //catch   = catches and handles exeptions when they occur
            //finally = always executes regardless if exception is caught or not
            double x, y, result;
            try
            {
                Console.Write("enter number 1:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("enter number 2:");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result:" + result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("enter only numbers!!!");
            }
            Console.ReadKey();

        }
    }
}
