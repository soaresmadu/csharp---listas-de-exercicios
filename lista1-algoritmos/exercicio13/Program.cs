using System;

namespace exercicio13 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Digite três valores: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maior = a;

            if (b > maior) {
                maior = b;
            }
            if (c > maior){
                maior = c;
            }

            Console.Write("MAIOR = " + maior);
            
 }
 }
} 
