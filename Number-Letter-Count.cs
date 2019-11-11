// github.com/cawhitecode
// Chris White

// https://projecteuler.net/problem=17

// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

// Answer = 21124;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLetterCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            // one to twenty, 
            int oneto9 = 36;
            int tento20 = 70;
            int twentyTo99 = 748;
            // 1 to 99 * 10 
            int hundred = 10 * (tento20 + oneto9 + twentyTo99);
            int hundreds = 7 * 9;
            int hundredAnd = 891 * 10;

            // one to 9 100 times, 
            int answer = oneto9 * 100 + hundred + hundreds + hundredAnd + 11;

            Console.WriteLine(answer);
            //string numbers = "";
            Console.ReadLine();

        }
    }
}