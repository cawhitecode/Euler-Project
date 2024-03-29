// github.com/cawhitecode
// Chris White

// https://projecteuler.net/problem=1

// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

// Answer = 233168

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOf3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // number 1 - 1000
            for (int x = 0; x < 1000; x++)
            {
                if ((x % 3 == 0) || (x % 5 == 0))
                {                    
                    sum += x;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}