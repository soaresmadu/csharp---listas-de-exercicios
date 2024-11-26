using System;

namespace exercicio6 {
    class Program {
        static void Main(string[] args) {
            
            int emSegundos;

            Console.Write("Digite a duração do evento (em segundos): ");
            emSegundos = int.Parse(Console.ReadLine());

            int horas = emSegundos/3600;
            int resto = (emSegundos%3600);
            int minutos = resto / 60;
            int segundos = resto%60;

            Console.WriteLine("O evento durou: " + horas + " hora(s), " + minutos + " minuto(s) e " + segundos + " segundo(s).");
               
 }
 }
} 

