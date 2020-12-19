using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_while_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! = {0}", factorial);
        }
    }
}
