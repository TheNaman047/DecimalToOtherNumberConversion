using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureUnitConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            FtoC();
            CtoF();
        }

        private static void CtoF()
        {
            double fahrenheit, celcius;
            Console.Write("Please enter current temprature in Celsius:- ");
            celcius = int.Parse(Console.ReadLine());
            fahrenheit = ((celcius * 9) / 5) + 32;
            Console.WriteLine("Value of Temprature in Fahrenheit is {0}", fahrenheit);
            Console.ReadLine();
        }

        private static void FtoC()
        {
            double fahrenheit, celcius;
            Console.Write("Please enter current temprature in Fahrenhiet:- ");
            fahrenheit = int.Parse(Console.ReadLine());
            celcius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine("Value of Temprature in Celcius is {0}", celcius);
            Console.ReadLine();
        }
    }
}
