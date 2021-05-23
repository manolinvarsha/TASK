using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3
{
    class Question5
    {
        public static void Main()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "Admin" || password != "admin")
                {
                    Console.WriteLine("Incorrect username or password.Try again");
                    ctr++;
                }
                else
                    Console.WriteLine("Welcome");
                ctr = 1;


            }
            while ((username != "Admin" || password != "admin") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attempt three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }
    }
}

