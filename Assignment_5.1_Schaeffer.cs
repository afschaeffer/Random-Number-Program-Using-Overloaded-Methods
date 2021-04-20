//Amy Schaeffer
// A program that calculates the average of 20 random numbers and the sum of 5 
// user entered double values using overloaded methods.

using System;

namespace Assignment_5._1_Schaeffer
{
    class Program

    {
        static void Main(string[] args)
        {
            int random; // declaring random number variable
            double average = 0; // declaring average variable
            double total = 0; // declaring total variable
            double input = 0; ; // declaring inputted number variable


            for (int i = 0; i < 20; i++) // loop that gets 20 random numbers 
            {
                random = getRandom(); // gets random number
                total = total + random; // adds numbers together
                calculate_average(total, ref average, 20); // calculates the total of 20 random numbers
            }

            Console.WriteLine("The average of the 20 random numbers is {0}", average); // writes average of random numbers

            total = 0; // resets the total

            for (int i = 0; i < 5; i++) // loop with 5 iterations asking for inputted double value
            {
                Console.Write("Please enter a double: "); // prompts user to enter double
                input = double.Parse(Console.ReadLine()); // converts entered value
                calculate_total(input, ref total); // calculates total of inputted values
            }

            Console.WriteLine("The total is {0}", total); // prints total of entered values from second for loop
        }

        static int getRandom() // method returning random number value used in first for loop
        {
            Random randomNumbers = new Random();
            return randomNumbers.Next(1, 101); // setting random number between 1 and 100
        }

        private static void calculate_average(double total, ref double average, double divisor) // void method that calculates average
        {
            average = total / divisor; // calculating average
        }

        private static void calculate_total(double consoleInput, ref double total) // void overload method that calculates the total
        {
            total += consoleInput; // adds inputted numbers together
        }

    }
}

