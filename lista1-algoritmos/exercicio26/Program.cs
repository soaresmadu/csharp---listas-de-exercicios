using System;

namespace exercicio26 {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite o valor em reais (R$): ");
            int valor = int.Parse(Console.ReadLine());

            int nota100 = valor / 100;
            int resto = valor % 100;
            int nota50 = resto / 50;
            resto %= 50;
            int nota10 = resto / 10;
            resto %= 10;
            int nota5 = resto / 5;
            int nota1 = resto%5;
            
            Console.WriteLine("Notas necessárias: ");
            if (nota100 > 0) {
                Console.WriteLine("Notas de 100: " + nota100);
            }
            if (nota50 > 0) {
                Console.WriteLine("Notas de 50: " + nota50);
            }
            if (nota10 > 0) {
                Console.WriteLine("Notas de 10: " + nota10);
            }
            if (nota5 > 0) {
                Console.WriteLine("Notas de 5: " + nota5);
            }
            if (nota1 > 0) {
                Console.WriteLine("Notas de 1: " + nota1);
            }
                               
 }
 }
} 

