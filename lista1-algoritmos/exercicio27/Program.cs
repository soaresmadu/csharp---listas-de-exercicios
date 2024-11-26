using System;
using System.Globalization;

namespace exercicio27 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Porcentagem do IPI: ");
            double ipi = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.Write("Código da peça 1: ");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário da peça 1: ");
            double valor1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade da peça 1: ");
            int qtd1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Código da peça 2: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário da peça 2: ");
            double valor2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade da peça 2: ");
            int qtd2 = int.Parse(Console.ReadLine());

            double formula = ((valor1*qtd1) + (valor2*qtd2)) * ((ipi/100) + 1);

            Console.WriteLine();
            Console.WriteLine("Valor total a ser pago: " + formula.ToString("F2", CI));
                               
 }
 }
} 

