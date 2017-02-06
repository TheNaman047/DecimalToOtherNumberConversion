using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number :- ");
            int a = int.Parse(Console.ReadLine());
            if (a < 20)
            {
                tens_units(a);
            }
            else
            {
                hundreads(a);
            }
            Console.ReadLine();
        }

        private static int tens_units(int a)
        {
            Console.WriteLine(Program.tens(a / 10) + " " + units(a % 10));
            return 0;
        }

        public static void hundreads(int a)
        {
            int num = a / 100;
            Console.Write(units(num) + " hundread and ");
            num = a % 100;
            Console.WriteLine(tens_units(num));
            string[] s = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        }
        public static string tens(int a)
        {
            string[] s = new string[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            return s[a];
        }
        public static string units(int a)
        {
            string[] s = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            return s[a];
        }
    }
}
