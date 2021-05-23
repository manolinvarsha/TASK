using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3
{
    class Question4
    {
        
        static void Main(string[] args)
        {
           
            var List = new List<int>();
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                if (number > 0)
                    List.Add(number);
                number = Convert.ToInt32(Console.ReadLine());
            }
           
            List.Sort();
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}





