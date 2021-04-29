using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo, segundoEntrada;

            segundoEntrada = int.Parse(Console.ReadLine());

            hora = segundoEntrada / 3600;
            minuto = (segundoEntrada % 3600) / 60;
            segundo = (segundoEntrada % 3600) % 60;

            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
        }
    }
}
