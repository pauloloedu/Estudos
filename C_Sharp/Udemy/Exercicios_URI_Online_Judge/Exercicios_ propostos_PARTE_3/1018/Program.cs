using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorEndtrada, n_100, n_50, n_20, n_10, n_5, n_2, n_1;

            valorEndtrada = int.Parse(Console.ReadLine());

            n_100 = valorEndtrada / 100;
            n_50 = (valorEndtrada % 100) / 50;
            n_20 = ((valorEndtrada % 100) % 50) / 20;
            n_10 = (((valorEndtrada % 100) % 50) % 20) / 10;
            n_5 = ((((valorEndtrada % 100) % 50) % 20) % 10) / 5;
            n_2 = (((((valorEndtrada % 100) % 50) % 20) % 10) % 5) / 2;
            n_1 = (((((valorEndtrada % 100) % 50) % 20) % 10) % 5) % 2;

            Console.WriteLine(valorEndtrada);
            Console.WriteLine(n_100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n_50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n_20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n_10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n_5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n_2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n_1 + " nota(s) de R$ 1,00");
        }
    }
}
