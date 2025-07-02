using System;

namespace TimesTable
{
    class Program
    /*
     * Ask the user for a number for the table
     * Write a for loop to print x times table
     */
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                // String interpolation
                Console.WriteLine($"{i} X {number} = {i * number}");
                // Format specifiers
                // Console.WriteLine("{0} X {1} = {2}", i, number, i * number);
            }
            Console.ReadLine();
        }
    }
}