using System;
using System.Globalization;

namespace exercicio9 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double nota1, nota2, nota3;

            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 3: ");
            nota3 = double.Parse(Console.ReadLine(), CI);

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine();
            Console.WriteLine("Média = " + media.ToString("F1", CI));
            if (media >= 6) {
                Console.Write("APROVADO");
            } else {
                Console.Write("REPROVADO");
            }

 }
 }
} 
