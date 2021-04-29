using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias, anos, meses, dias;

            idadeEmDias = int.Parse(Console.ReadLine());

            anos = idadeEmDias / 365;
            meses = (idadeEmDias % 365) / 30;
            dias =  (idadeEmDias % 365) % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
