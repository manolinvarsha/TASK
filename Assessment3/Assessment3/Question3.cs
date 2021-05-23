using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assessment3
{
    class Question3
    {
        public static void Main()
        {
            List<int> number = new List<int>();
            Console.WriteLine("Enter the number if you want to quit enter the neagative number");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    number.Add(i);
            }
            IEnumerable<int> result = number.GroupBy(r => r).Where(r => r.Count() > 1).Select(r => r.Key);
            Console.WriteLine("Repeated Numbers are:");
            foreach (var solution in result)
            {
                Console.WriteLine(solution);
            }
        }
    }
}


