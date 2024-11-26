using System;
using System.Globalization;

namespace exercicio30 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Qual o índice de poluição atual? ");
            double indice = double.Parse(Console.ReadLine(), CI);

            if (indice >= 0.5){
                Console.WriteLine("Notificação emitida para os Grupos 1, 2 e 3.");
            } else if (indice >= 0.4) {
                Console.WriteLine("Notificação emitida para os Grupos 1 e 2.");
            } else if (indice >= 0.3) {
                Console.WriteLine("Notificação emitida para o Grupo 1.");
            } else {
                Console.WriteLine("O índice de poluição está dentro do limite aceitável.");
            }

 }
 }
} 