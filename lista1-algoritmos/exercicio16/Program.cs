using System;
using System.Globalization;

namespace exercicio16 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            double preco = 0;

            switch (codigo){
                case 100:
                preco = 1.20;
                break;

                case 101:
                preco = 1.30;
                break;

                case 102:
                preco = 1.50;
                break;

                case 103:
                preco = 1.20;
                break;

                case 104:
                preco = 1.30;
                break;

                case 105:
                preco = 1.00;
                break;
            }

            double valorTotal = qtd * preco;

            Console.WriteLine("Valor total: " + valorTotal.ToString("F2", CI));

 }
 }
} 