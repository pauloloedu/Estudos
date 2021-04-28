using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velMedia;
            double distPercorrida, qtdeLitros;

            tempo = int.Parse(Console.ReadLine());
            velMedia = int.Parse(Console.ReadLine());

            distPercorrida = (double) velMedia * tempo;
            qtdeLitros = (double) distPercorrida / 12;

            Console.WriteLine(qtdeLitros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
