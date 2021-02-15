using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork2
{
    class HWork
    {
        #region example 1
        public static int GetLet(char ch, string str)
        {
            int count = 1;
            List<char> list = str.ToList();
            list.Remove(ch);
            for (int i = 0; i < list.Count; i++)
            {
                if (ch == list[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static List<char> RemoveDublicats(string str)
        {
            List<char> list = str.ToList();
            list = list.Distinct().ToList();
            return list;
        }
        public static void GetNewString(string str)
        {
            var arr = str.ToCharArray();
            string result = "";
            List<char> list = RemoveDublicats(str);
            int[] countLet = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                countLet[i] = GetLet(list[i],str);
            }
            for (int i = 0; i < countLet.Length; i++)
            {
                result += list[i] + countLet[i].ToString();
            }
            Console.WriteLine(str);
            Console.WriteLine(result);
        }

        #endregion


        #region example 2

        public static void GetReplace(string str, string add)
        {
            string str3 = "";

            string[] str2 = str.Split(" ");
            foreach (var item in str2)
            {
                str3 += item + add;
            }
            Console.WriteLine(str);
            Console.WriteLine(str3);
        }

        #endregion


        #region example 3

        public static string DayInMonth(int month)
        {
            string result = "";
            result = month switch
            {
                1 => "31",
                2 => "28 or 29",
                3 => "31",
                4 => "30",
                5 => "31",
                6 => "30",
                7 => "31",
                8 => "31",
                9 => "30",
                10 => "31",
                11 => "30",
                12 => "31",
                _ => "You write non correct moonth"
            };

            return $"This month has {result} days";
        }

        #endregion

        #region example 4

        private static string GradeMapping(int num)
        {
            string result = "";
            result = num switch
            {
                0 => "F",
                1 => "F",
                2 => "F",
                3 => "F",
                4 => "F",
                5 => "D",
                6 => "C",
                7 => "B",
                8 => "B",
                9 => "A",
                10 => "A+",
                _ => "You write non correct moonth"
            };
            return result;
        }
        public static void ShowGrade()
        {
            Console.WriteLine($"Numerical value  \tGrade");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i}\t\t\t{GradeMapping(i)}");
            }
        }


        #endregion

        #region Calculator

        public static void StartCalc()
        {
            int num1 = 0;
            int num2 = 0;
            char op = '.';

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter a first number");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            bool isParse = int.TryParse(Console.ReadLine(), out int result);
            if (isParse)
            {
                num1 = result;
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please select a operation\n" +
                "For Sum. press  +\n" +
                "For Sub. press  -\n" +
                "For Div. press  /\n" +
                "For Mult press  *\n" +
                "For Sqrt press  s\n" +
                "For Exit press x");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            string input = Console.ReadLine().ToLower();
            if (char.TryParse(input, out char operation))
            {
                op = operation;
            }
            Console.ResetColor();
            if (op != 'x')
            {
                if (op != 's')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Please enter a second number\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    bool isParse2 = int.TryParse(Console.ReadLine(), out int result2);
                    if (isParse2)
                    {
                        num2 = result2;
                    }
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Second number is zero");
                        }
                        break;
                    case 's':
                        Console.WriteLine($"{Math.Sqrt(num1)}");
                        break;
                    default:
                        Console.WriteLine("Sorry you write a non correct operation");
                        break;
                }
                Console.ResetColor();
            }
            
            
            #endregion

        }
    }
}
