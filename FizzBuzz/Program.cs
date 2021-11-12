using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    { 
        static void Main(string[] args)
        {
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            List<string> lstReturn = new List<string>();
            Worker work = new Worker();
            string strReturn = "";

            // * Adds the upper bound int and returns list with upperbound.
            userInput = work.addUpperBound(userInput, 100);

            // * Adds the first number we get to check for divisors out of the range of ints and replaces all divisors of that number with a word.
            userInput = work.addFirstDivisorAndReplacement(userInput, 3, "Fizz");
            // * Adds the second number we get to check for divisors out of the range of ints and replaces all divisors of that number with a word.
            userInput = work.addSecondDivisorAndReplacement(userInput, 5, "Buzz");
            // * Returns list of strings that print our range of number with the chosen text to replace their respective divisors.
            lstReturn = work.getListOfNumbersAndReplacementText(userInput);

            foreach(string item in lstReturn)
            {
                strReturn = strReturn + item + "\n";
            }

            Console.WriteLine(strReturn);

            // * Keep the console open.
            Console.ReadLine();
        }
    }
}
