using System;


namespace NumberSum
{
    static class View
    {
        static public int count = 0;
        public static void Display()
        {
            Console.WriteLine("Please enter a number");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int res))
            {
                Check.CheckSecret(res);
            }
            else
            {
                count++;
                Console.WriteLine("Number non correct\nPlease try again\n");
                View.Display();
            }
        }
    }
}
