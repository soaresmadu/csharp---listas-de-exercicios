using System;
using System.Globalization;

namespace exercicio29 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Informações do aluno: ");
            Console.Write("Número de identificação: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Média dos exercícios: ");
            double mediaE = double.Parse(Console.ReadLine(), CI);

            double mediaA = (nota1 + (nota2*2) + (nota3*3) + mediaE) / 7;

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO FINAL DO ALUNO: ");
            Console.WriteLine("Número de identificação: " + numero);
            Console.WriteLine("Nota 1: " + nota1.ToString("F1", CI));
            Console.WriteLine("Nota 2: " + nota2.ToString("F1", CI));
            Console.WriteLine("Nota 3: " + nota3.ToString("F1", CI));
            Console.WriteLine("Média dos exercícios: " + mediaE.ToString("F1", CI));
            Console.WriteLine("Média de Aproveitamento: " + mediaA.ToString("F1", CI));

            if (mediaA >= 9) {
                Console.WriteLine("Conceito: A");
                Console.WriteLine("APROVADO");
            } else if (mediaA >= 7.5 && mediaA < 9) {
                Console.WriteLine("Conceito: B");
                Console.WriteLine("APROVADO");
            } else if (mediaA >= 6 && mediaA < 7.5) {
                Console.WriteLine("Conceito: C");
                Console.WriteLine("APROVADO");
            } else if (mediaA >= 4 && mediaA < 6) {
                Console.WriteLine("Conceito: D");
                Console.WriteLine("REPROVADO");
            } else if (mediaA < 4) {
                Console.WriteLine("Conceito: E");
                Console.WriteLine("REPROVADO");
            }

 }
 }
} 

