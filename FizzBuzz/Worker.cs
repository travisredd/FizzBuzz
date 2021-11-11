using System;
using System.Collections.Generic;
using FizzBuzz.Controls;

namespace FizzBuzz
{
    class Worker
    {
        FizzBuzzControls fbc = new FizzBuzzControls();
        UserInput ui = new UserInput();
        Dictionary<string, object> userInput = new Dictionary<string, object>();

        public void doWork()
        {
            string strPromptUser = "";
            strPromptUser += "***************************************************************************************************************\n";
            strPromptUser += "This program will prompt you for 5 different inputs.\n";
            strPromptUser += "1) First input should be an integer between 1 and 10,000\n";
            strPromptUser += "...this integer will be the range of numbers that we print out, between 1 and the integer you choose:\n";
            strPromptUser += "2) The second prompt will ask you to enter a number, we will use this number to replace all of it's divisors in our range with a word.\n";
            strPromptUser += "3) The third prompt is the word you want us to replace the above numbers divisor with.\n";
            strPromptUser += "4) The fourth prompt will ask you to enter a number, we will use this number to replace all of it's divisors in our range with a word.\n";
            strPromptUser += "5) The fifth and final prompt is the word you want us to replace the above numbers divisor with.\n";
            strPromptUser += "***************************************************************************************************************\n";
            Console.WriteLine(strPromptUser);

            getUpperBound();
            getFirstDivisorAndStatement();
            getSecondDivisorAndStatement();

            Console.WriteLine(fbc.fizzBuzz(userInput));
        }

        public void getUpperBound()
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Write("Enter an upper bound number greater than 0: ");
                try
                {
                    ui.intMax = Convert.ToInt32(Console.ReadLine());
                    if (ui.intMax > 0 && ui.intMax <= 10000)
                    {
                        userInput.Add("intMax", ui.intMax);
                        keepLooping = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    keepLooping = true;
                    Console.WriteLine("Not the correct input. Try again.");

                    // * TODO print error e to our log file.
                }
            }
        }

        public void getFirstDivisorAndStatement()
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                try
                {
                    Console.Write("Enter the first divisor: ");
                    ui.firstDivisor = Convert.ToInt32(Console.ReadLine());
                    if (ui.firstDivisor > 0)
                    {
                        userInput.Add("firstDivisor", ui.firstDivisor);
                        Console.Write("Enter the first divisor replacement text: ");
                        ui.firstDivisorReplacement = Console.ReadLine();
                        userInput.Add("firstDivisorReplacement", ui.firstDivisorReplacement);

                        keepLooping = false;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception e)
                {
                    keepLooping = true;
                    Console.WriteLine("Not the correct input. Try again.");

                    // * TODO print error e to our log file.
                }
            }
        }

        public void getSecondDivisorAndStatement()
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                try
                {
                    Console.Write("Enter the second divisor: ");
                    ui.secondDivisor = Convert.ToInt32(Console.ReadLine());
                    if (ui.secondDivisor > 0)
                    {
                        userInput.Add("secondDivisor", ui.secondDivisor);
                        Console.Write("Enter the second divisor replacement text: ");
                        ui.secondDivisorReplacement = Console.ReadLine();
                        userInput.Add("secondDivisorReplacement", ui.secondDivisorReplacement);
                        keepLooping = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    keepLooping = true;
                    Console.WriteLine("Not the correct input. Try again.");

                    // * TODO print error e to our log file.
                }
            }
        }
    }
}
