// github.com/cawhitecode
// Chris White

// The prime factors of 13195 are 5, 7, 13 and 29.

// What is the largest prime factor of the number 600851475143 ?

// Answer = 6857

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargePrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            const long longNumber = 600851475143;
            long newLongNumber = longNumber;
            long largestFact = 0;

            int counter = 2;
            while (counter * counter <= newLongNumber)
            {
                if (newLongNumber % counter == 0)
                {
                    newLongNumber = newLongNumber / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (newLongNumber > largestFact)
            { 
                largestFact = newLongNumber;
            }
            Console.WriteLine(largestFact);
            Console.ReadLine();

        }
    }
}