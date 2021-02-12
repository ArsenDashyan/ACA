using System;
using System.Collections.Generic;
using System.Text;

namespace Example702
{
    class Desktop
    {
        #region example1
        public static void MultOrSum()
        {
            Console.WriteLine("Please enter a number");
            string str = Console.ReadLine();
            if (!int.TryParse(str, out int result))
            {
                MultOrSum();
            }
            else
            {
                Console.WriteLine("Please select a action\n");
                Console.WriteLine("For computing sum enter 1");
                Console.WriteLine("For computing multiplication enter 2\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Number sum is {result * (result + 1) / 2}");
                        break;
                    case "2":
                        int mult = 1;
                        for (int i = 1; i <= result; i++)
                        {
                            mult *= i;
                        }
                        Console.WriteLine($"Number multiplicaton is {mult}");
                        break;
                    default:
                        Console.WriteLine("Sorry you write a non correct action!");
                        break;
                }

            }
        }
        #endregion

        #region example2

        public static void LeapYear(int count, int start)
        {
            DateTime date = new DateTime(start, 12, 31);
            if (date.DayOfYear == 366)
            {
                PrintLeapYears(count,start);
            }
            else
            {
                for (int i = 1; i < 4; i++)
                {
                    date = date.AddYears(i);
                    if (date.DayOfYear == 366)
                    {
                        PrintLeapYears(count, start);
                    }
                }
            }
        }

        private static void PrintLeapYears(int count, int start)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{start + 4 * i} is a Leap Year");
            }
        }

        #endregion

        #region example3
        public static void ListInBox(List<string> list)
        {
            int max = 1;

            foreach (var item in list)
            {
                if (max < item.Length)
                {
                    max = item.Length;
                }
            }

            for (int i = 0; i < list.Count * 2 + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == 0 || i == list.Count * 2 || j == 0)
                    {
                        Console.Write("* ");
                    }
                    else if (j == max - 1)
                    {
                        Console.SetCursorPosition((max - 1) * 2, i);
                        Console.Write("*");
                    }
                    Console.Write("");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(max / 2, 1 + i * 2);
                Console.WriteLine(list[i]);
            }
        }

        #endregion

        #region example4

        public static void AddEy(string text)
        {
            string[] newText = text.Split(" ");

            string[] result = ArrayRem(newText);
            string res = "";
            foreach (var item in result)
            {
                res += item;
            }

            Console.WriteLine(text + "\n" + res);
        }

        public static string[] ArrayRem(string[] str)
        {
            string[] newStr = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                string temp = str[i].Remove(0, 1) + str[i][0];
                newStr[i] = temp.Insert(temp.Length, "ey ");
            }
            return newStr;
        }

        #endregion
    }
}
