using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment3
{
    class Question6
    {
        public static int min;

        public static void Main()
        {
            string[] arr = { "kite", "four", "neat", "play", "goal" };

            Console.WriteLine("Play.......");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the guess");
                string GuessWord = Console.ReadLine();
                string guess = arr[i];
                int cow = 0, bulls = 0;
                if (guess.Length == GuessWord.Length)
                {

                    for (i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == GuessWord[i])
                        {
                            cow += 1;
                        }
                        else
                        {
                            for (int j = 0; j < guess.Length; j++)
                            {
                                if (guess[i] == GuessWord[j] && i != j)
                                {
                                    bulls += 1;
                                }
                            }
                        }
                        Console.WriteLine("Cows--" + cow + " Bulls--" + bulls);
                    }

                    if (cow == guess.Length)
                    {
                        Console.WriteLine("Congratulations You Won the Game");
                    }
                    Console.WriteLine("                    ");
                }
                else
                {
                    Console.WriteLine("Must enter " + guess.Length + " letter a Word");
                    Console.WriteLine("");
                }
            }
        }
    }
}








