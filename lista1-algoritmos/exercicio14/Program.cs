using System;
using System.Globalization;

namespace exercicio14 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Código do(a) aluno(a): ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CI);

            double media = 0;

            if (nota1 > nota2 && nota1 > nota3) {
                media = ((nota1*4) + (nota2*3) + (nota3*3))/10;
            } else if (nota2 > nota1 && nota2 > nota3) {
                media = ((nota2*4) + (nota1*3) + (nota3*3))/10;
            } else {
                media = ((nota3*4) + (nota1*3) + (nota2*3))/10;
            }

            Console.WriteLine();
            Console.WriteLine("Relatório final: ");
            Console.WriteLine("Código do(a) aluno(a): " + codigo);
            Console.WriteLine("Nota 1: " + nota1.ToString("F2", CI));
            Console.WriteLine("Nota 2: " + nota2.ToString("F2", CI));
            Console.WriteLine("Nota 3: " + nota3.ToString("F2", CI));
            Console.WriteLine("Média do aluno(a): " + media.ToString("F2", CI));
            if (media >= 5) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
            }
            
 }
 }
} 
