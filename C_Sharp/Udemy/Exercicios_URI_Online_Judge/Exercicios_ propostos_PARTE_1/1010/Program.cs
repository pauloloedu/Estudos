using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, qtde1, qtde2;
            double valorUni1, valorUni2, total;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            qtde1 = int.Parse(vet[1]);
            valorUni1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet[0]);
            qtde2 = int.Parse(vet[1]);
            valorUni2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = (double)(qtde1 * valorUni1) + (qtde2 * valorUni2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
