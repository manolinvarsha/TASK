using System;

namespace Assessment3
{
    class Question2
    {
        static void Main(string[] args)
        {

            int min, max, i, j, flag;

            // Ask user to enter lower value of interval
            Console.WriteLine("Enter the minimum value of " +
                              "the interval: ");

            // Take input
            min = int.Parse(Console.ReadLine());

            // Ask user to enter upper value of interval
            Console.WriteLine("\nEnter the maximum value  " +
                              "of the interval: ");

            // Take input
            max = int.Parse(Console.ReadLine());

            // Print display message
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", min, max);

            // Traverse each number in the interval
            // with the help of for loop
            for (i = min; i <= max; i++)
            {

                // Skip 0 and 1 as they are
                // niether prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}


