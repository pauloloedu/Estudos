using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numfuncionario, numhoras;
            double valorhora, salario;

            numfuncionario = int.Parse(Console.ReadLine());
            numhoras = int.Parse(Console.ReadLine());
            valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numhoras * valorhora;

            Console.WriteLine("NUMBER = " + numfuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
