using System;

namespace FizzBuzz
{
    class Program
    {
        /*
         * Create a for loop from 1 to X
         * 3 and 5 FizzBuzz
         * 3 = Fizz
         * 5 = Buzz
         * else = number
         */ 
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= 15; i++) 
            { 
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

