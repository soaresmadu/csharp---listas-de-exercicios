using System;
using System.Globalization;

namespace exercicio21 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Código: ");
            string codigo = Console.ReadLine().ToUpper();
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            double preco = 0;

            switch (codigo){
                case "ABCD":
                    preco = 5.30;
                break;

                case "XYPK":
                    preco = 6.00;
                break;

                case "KLMP":
                    preco = 3.20;
                break;

                case "QRST":
                    preco = 2.50;
                break;

                default:
                    Console.Write("Código Inválido");
                return;
            }

            double precoTotal = qtd * preco;

            Console.WriteLine("Preço total: R$ " + precoTotal.ToString("F2", CI));
            
 }
 }
} 

