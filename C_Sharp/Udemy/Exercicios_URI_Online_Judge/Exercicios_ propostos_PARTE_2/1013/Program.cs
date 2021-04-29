using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maiorABC;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");
        }
    }
}
