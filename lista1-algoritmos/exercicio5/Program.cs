using System;
using System.Globalization;

namespace exercicio5 {
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

            double media = ((nota1*2) + (nota2*3) + (nota3*5)) / 10;

            Console.WriteLine();
            Console.Write("Média final: " + media.ToString("F2", CI));
               
 }
 }
} 
