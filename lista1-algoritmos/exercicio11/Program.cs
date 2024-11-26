using System;

namespace exercicio11 {
    class Program {
        static void Main(string[] args) {
            
            int a, b;

            Console.Write("Valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Valor de b: ");
            b = int.Parse(Console.ReadLine());

            if (a%b == 0 || b%a == 0) {
                Console.Write("SÃO MÚLTIPLOS");
            } else {
                Console.Write("NÃO SÃO MÚLTIPLOS");
            }

 }
 }
} 