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
                throw new Exception("Not the correct input. Try again.\n" + e);
            }
            return userInput;
        }

        public Dictionary<string, object> addFirstDivisorAndReplacement(Dictionary<string, object> userInput, int fDivisor, string fReplacement)
        {
            try
            {
                if (fDivisor > 0 && fDivisor <= (int)userInput["intMax"])
                {
                    userInput.Add("firstDivisor", fDivisor);
                    userInput.Add("firstDivisorReplacement", fReplacement);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not the correct input. Try again.\n" + e);
            }            
            return userInput;
        }

        public Dictionary<string, object> addSecondDivisorAndReplacement(Dictionary<string, object> userInput, int sDivisor, string sReplacement)
        {
            try
            {

                if (sDivisor > 0 && sDivisor <= (int)userInput["intMax"])
                {
                    userInput.Add("secondDivisor", sDivisor);
                    userInput.Add("secondDivisorReplacement", sReplacement);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not the correct input. Try again.\n" + e);
            }
            return userInput;
        }
    }
}
