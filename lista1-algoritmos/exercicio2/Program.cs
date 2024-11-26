
using System;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {
            
            int a, b, c;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            int R = (a+b)*(a+b);
            int S = (b+c)*(b+c);

            int D = (R + S) / 2;

            Console.WriteLine("RESULTADO = " + D);
            
 }
 }
} 
