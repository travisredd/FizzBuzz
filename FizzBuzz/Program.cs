using System;
using System.Collections.Generic;
using FizzBuzz.Controls;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();
            work.doWork();

            Console.ReadLine();
        }
    }

    class Worker
    {
        FizzBuzzControls fbc = new FizzBuzzControls();
        UserInput ui = new UserInput();
        Dictionary<string, object> userInput = new Dictionary<string, object>();

        public void doWork()
        {
            Console.Write("Enter an upper bound number: ");
            ui.intMax = Convert.ToInt32(Console.ReadLine());
            userInput.Add("intMax", ui.intMax);

            Console.Write("Enter the small divisor: ");
            ui.smallDivisor = Convert.ToInt32(Console.ReadLine());
            userInput.Add("smallDivisor", ui.smallDivisor);

            Console.Write("Enter the large divisor: ");
            ui.largeDivisor = Convert.ToInt32(Console.ReadLine());
            userInput.Add("largeDivisor", ui.largeDivisor);

            Console.Write("Enter the small divisor print statement: ");
            ui.smallDivisorPrint = Console.ReadLine();
            userInput.Add("smallDivisorPrint", ui.smallDivisorPrint);

            Console.Write("Enter the large divisor print statement: ");
            ui.largeDivisorPrint = Console.ReadLine();
            userInput.Add("largeDivisorPrint", ui.largeDivisorPrint);

            Console.WriteLine(fbc.fizzBuzz(userInput));
        }
    }
}
