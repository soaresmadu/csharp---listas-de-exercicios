using System;

namespace exercicio12 {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite a idade do(a) nadador(a): ");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade >= 5 && idade <= 7) {
                Console.Write("INFANTIL A");
            }
            else if (idade >= 8 && idade <= 10) {
                Console.Write("INFANTIL B");
            }
            else if (idade >= 11 && idade <= 13) {
                Console.Write("JUVENIL A");
            }
            else if (idade >= 14 && idade <= 17) {
                Console.Write("JUVENIL B");
            }
            else if (idade >= 18) {
                Console.Write("ADULTO");
            }
            else {
                Console.WriteLine("Idade inválida.");
            }

 }
 }
} 
