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

            // * Adds the upper bound int to the userInput object.
            userInput = work.addUpperBound(userInput, 100);
            // * Adds the first divisor and string that we replace the first divisor with to the userInput object.
            userInput = work.addFirstDivisorAndReplacement(userInput, 3, "Fizz");
            // * Adds the second divisor and string that we replace the second divisor with to the userInput object.
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
