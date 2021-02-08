using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberSum
{
    static class Check
    {
        static List<string> list = new List<string>();
        static Random rnd = new Random();
        static int secret = rnd.Next(0, 10);
        public static void CheckSecret(int number)
        {
            list.Add(number.ToString());
            if (number == secret)
            {
                var NewList = list.Distinct().ToList();
                Console.WriteLine($"You win!!! Your score is {NewList.Count + View.count}");
            }
            else if (number > secret)
            {
                Console.WriteLine("Your number is greater than the secret number\n--Sorry try again--\n");
                View.Display();
            }
            else
            {
                Console.WriteLine("Your number is smaller than the secret number\n--Sorry try again--\n");
                View.Display();
            }

            
        }
        
    }
}
