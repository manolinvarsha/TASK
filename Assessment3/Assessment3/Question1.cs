using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3
{
    class Question1
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.Write("\nEnter your number {0}:\t", i);

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("The numbers divisible by 7 are :");


            for (i = 0; i < 10; i++)
            {

                if (arr[i] % 7 == 0)
                {
                    Console.WriteLine("{0}", arr[i]);
                }

            }

        }
    }
}


