using System;

namespace ReverseString
{
    class Program
    {
        /*
         * Ask user to input a message
         * Print in order
         * Print in reverse
         */
        static void Main(string[] args) 
        {
            Console.Write("Enter a message: ");
            string? message = Console.ReadLine();

            for (int i = 0; i < message?.Length; i++) 
            { 
                Console.WriteLine(message[i]);
            }
            Console.WriteLine();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
