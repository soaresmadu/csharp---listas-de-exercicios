using System;

namespace exercicio24 {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Hora inicial: ");
            int inicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            int final = int.Parse(Console.ReadLine());
            
            int duracao = 0;

            if (inicial < final) {
                duracao = final - inicial;
            } else {
                duracao = (final + 24) - inicial;
            }

            Console.WriteLine("O jogo durou " + duracao + " hora(s).");
                                      
 }
 }
} 
