using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorEntrada, n_100, n_50, n_20, n_10, n_5, n_2, m_1, m_050, m_025, m_010, m_005, m_001;

            valorEntrada = 100 * double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            n_100 = (int)valorEntrada / 10000;
            n_50 = (int)(valorEntrada % 10000) / 5000;
            n_20 = (int)((valorEntrada % 10000) % 5000) / 2000;
            n_10 = (int)(((valorEntrada % 10000) % 5000) % 2000) / 1000;
            n_5 = (int)((((valorEntrada % 10000) % 5000) % 2000) % 1000) / 500;
            n_2 = (int)(((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) / 200;
            m_1 = (int)((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) / 100;
            m_050 = (int)(((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) / 50;
            m_025 = (int)((((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) / 25;
            m_010 = (int)(((((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) / 10;
            m_005 = (int)((((((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) / 5;
            m_001 = (int)(((((((((((valorEntrada % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) % 5);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n_100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n_50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n_20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n_10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n_5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n_2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m_1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m_050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m_025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m_010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m_005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m_001 + " moeda(s) de R$ 0.01");
        }
    }
}
