using System;

namespace Square_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the last number");
            int input = int.Parse(Console.ReadLine());

            int squareOfAllNumbers = 0;

            int sumOfNumbers = 0;

            for (int i = 1; i <= input; i++)
            {
                squareOfAllNumbers += (i * i);
            }


            for (int i = 1; i <= input; i++)
            {
                sumOfNumbers += i;
            }
            int squareOfSumOfTheNumbers = sumOfNumbers * sumOfNumbers;

            Console.WriteLine(squareOfSumOfTheNumbers - squareOfAllNumbers);


        }
    }
}
