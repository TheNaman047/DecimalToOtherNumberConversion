using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToOtherNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            DtoB();
            DtoO();
            DtoH();
        }

        private static void DtoH()
        {
            string hexString = "";
            int remainder = 0;
            Console.Write("Please enter a decimal number to convert it to Hexadecimal:- ");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % 16;
                if (remainder < 10)
                {
                    hexString = (remainder).ToString() + hexString;
                }
                else
                {
                    if(remainder == 10)
                    {
                        hexString = ('A').ToString() + hexString;
                    }

                    else if (remainder == 11)
                    {
                        hexString = ('B').ToString() + hexString;
                    }

                    else if (remainder == 12)
                    {
                        hexString = ('C').ToString() + hexString;
                    }

                    else if (remainder == 13)
                    {
                        hexString = ('D').ToString() + hexString;
                    }

                    else if (remainder == 14)
                    {
                        hexString = ('E').ToString() + hexString;
                    }

                    else if (remainder == 15)
                    {
                        hexString = ('F').ToString() + hexString;
                    }
                }
                number /= 16;
            }
            Console.WriteLine(hexString);
            Console.ReadLine();
        }

        private static void DtoO()
        {
            string binaryString = "";
            Console.Write("Please enter a decimal number to convert it to Binary:- ");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                binaryString = (number % 8).ToString() + binaryString;
                number /= 8;
            }
            Console.WriteLine(binaryString);
            Console.ReadLine();
        }

        private static void DtoB()
        {
            string octalString = "";
            Console.Write("Please enter a decimal number to convert it to Octal:- ");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                octalString = (number % 2).ToString() + octalString;
                number /= 2;
            }
            Console.WriteLine(octalString);
            Console.ReadLine();
        }
    }
}