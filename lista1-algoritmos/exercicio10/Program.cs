using System;

namespace exercicio10 {
    class Program {
        static void Main(string[] args) {
            
            int a, b, c;

            Console.Write("A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            c = int.Parse(Console.ReadLine());

            int maior = a;

            if (b > maior) {
                maior = b;
            }       
            if (c > maior) {
                maior = c;
            }

            Console.WriteLine(maior + " é o maior.");
 }
 }
} 
