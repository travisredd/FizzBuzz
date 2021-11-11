using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();
            work.doWork();

            // * Keep the console open.
            Console.ReadLine();
        }
    }
}
