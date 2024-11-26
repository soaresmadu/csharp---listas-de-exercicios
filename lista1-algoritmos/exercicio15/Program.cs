using System;

namespace exercicio15 {
    class Program {
        static void Main(string[] args) {

        Console.Write("Digite um número: ");
        int x = int.Parse(Console.ReadLine());

        if (x%2 == 0) {
            Console.Write("PAR");
        } else {
            Console.Write("ÍMPAR");
        }
            
 }
 }
} 
