using System;
using System.Collections.Generic;
using FizzBuzz.Controls;

namespace FizzBuzz
{
    public class Worker
    {
        FizzBuzzControls fbc;
        public Worker() {
            fbc = new FizzBuzzControls();
        }
        
        public List<string> getListOfNumbersAndReplacementText(Dictionary<string, object> userInput)
        {
            return fbc.fizzBuzz(userInput);
        }

        public Dictionary<string, object> addUpperBound(Dictionary<string, object> userInput, int intMax)
        {
            try
            {
                if (intMax > 0 && intMax <= 10000)
                {
                    userInput.Add("intMax", intMax);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not the correct input. Try again.\n");
                throw new Exception("Error: \n" + e);

            }
            return userInput;
        }

        public Dictionary<string, object> addFirstDivisorAndReplacement(Dictionary<string, object> userInput, int intFirstDivisor, string strFirstReplacement)
        {
            try
            {
                if (intFirstDivisor > 0 && intFirstDivisor <= (int)userInput["intMax"])
                {
                    userInput.Add("firstDivisor", intFirstDivisor);
                    userInput.Add("firstDivisorReplacement", strFirstReplacement);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not the correct input. Try again.\n" + e);
                throw new Exception("Error: \n" + e);
            }            
            return userInput;
        }

        public Dictionary<string, object> addSecondDivisorAndReplacement(Dictionary<string, object> userInput, int intSecondDivisor, string strSecondReplacement)
        {
            try
            {
                if (intSecondDivisor > 0 && intSecondDivisor <= (int)userInput["intMax"])
                {
                    userInput.Add("secondDivisor", intSecondDivisor);
                    userInput.Add("secondDivisorReplacement", strSecondReplacement);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not the correct input. Try again.\n" + e);
                throw new Exception("Error: \n" + e);
            }
            return userInput;  
        }
    }
}
