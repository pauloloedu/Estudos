using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double area, raio, n;
            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (Math.Pow(raio, 2));

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
