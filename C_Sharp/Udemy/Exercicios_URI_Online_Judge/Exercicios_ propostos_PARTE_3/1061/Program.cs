using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio;
            int diaFim, horaFim, minutoFim, segundoFim;
            int duracaoDias, duracaoHoras, duracaoMinutos, duracaoSegundos;
            
            string[] dataInicio = Console.ReadLine().Split(' ');
            string[] horarioInicio = Console.ReadLine().Split(' ');

            diaInicio = Int32.Parse(dataInicio[1]);
            horaInicio = Int32.Parse(horarioInicio[0]);
            minutoInicio = Int32.Parse(horarioInicio[2]);
            segundoInicio = Int32.Parse(horarioInicio[4]);

            string[] dataFim = Console.ReadLine().Split(' ');
            string[] horarioFim = Console.ReadLine().Split(' ');

            diaFim = Int32.Parse(dataFim[1]);
            horaFim = Int32.Parse(horarioFim[0]);
            minutoFim = Int32.Parse(horarioFim[2]);
            segundoFim = Int32.Parse(horarioFim[4]);

            int inicio = (diaInicio - 1) * 86400 + (horaInicio) * 3600 + (minutoInicio) * 60 + segundoInicio;
            int fim = (diaFim - 1) * 86400 + (horaFim) * 3600 + (minutoFim) * 60 + segundoFim;
            int duracao = fim - inicio;

            duracaoDias = duracao / 86400;
            var restoHoras = duracao % 86400;

            duracaoHoras = restoHoras / 3600;
            var restoMinutos = restoHoras % 3600;

            duracaoMinutos = restoMinutos / 60;
            duracaoSegundos = restoMinutos % 60;

            Console.WriteLine(duracaoDias + " dia(s)");
            Console.WriteLine(duracaoHoras + " hora(s)");
            Console.WriteLine(duracaoMinutos + " minuto(s)");
            Console.WriteLine(duracaoSegundos + " segundo(s)");
        }
    }
}
