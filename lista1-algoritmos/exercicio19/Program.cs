using System;
using System.Globalization;

namespace exercicio19 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Tipo de nota (1-Aritmética, 2-Ponderada, 3-Harmônica): ");
            int tipo = int.Parse(Console.ReadLine());

            double media = 0;

            switch (tipo){
                case 1:
                    media = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine("Média Aritmética: " + media.ToString("F2", CI));
                break;

                case 2:
                    media = (nota1*3 + nota2*3 + nota3*4) / 10;
                    Console.WriteLine("Média Ponderada: " + media.ToString("F2", CI));
                break;

                case 3:
                    if(nota1 != 0 && nota2 != 0 && nota3 != 00) {
                        media = 3 / (1/nota1 + 1/nota2 + 1/nota3);
                        Console.WriteLine("Média Ponderada: " + media.ToString("F2", CI));
                    } else {
                        Console.WriteLine("Impossível calcular.");
                    }
                break;

                default:
                    Console.WriteLine("Opção inválida.");
                break;
            }

            

 }
 }
} 
