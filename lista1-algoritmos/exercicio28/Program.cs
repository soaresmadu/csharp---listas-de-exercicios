using System;

namespace exercicio28 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Início do evento: ");
            Console.Write("Horas: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            int minutosInicial = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Final do evento: ");
            Console.Write("Horas: ");
            int horaFinal = int.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            int minutosFinal = int.Parse(Console.ReadLine());

            int totalInicio = horaInicial * 60 + minutosInicial;
            int totalFinal = horaFinal * 60 + minutosFinal;

            if (totalFinal <= totalInicio) {
                totalFinal += 24*60;
            }

            int duracaoMinutos = totalFinal - totalInicio;

            int duracaoHoras = duracaoMinutos / 60;
            int duracaoTotalMinutos = duracaoMinutos % 60;

            Console.WriteLine();
            Console.Write("O jogo durou " + duracaoHoras + " hora(s) e " + duracaoTotalMinutos + " minuto(s).");

 }
 }
} 

