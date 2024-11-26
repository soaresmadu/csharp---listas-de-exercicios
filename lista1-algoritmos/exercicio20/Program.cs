using System;
using System.Globalization;

namespace exercicio20 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            double preco = 0;

            switch (codigo){
                case 1001:
                    preco = 5.32;
                break;

                case 1324:
                    preco = 6.45;
                break;

                case 6548:
                    preco = 2.37;
                break;

                case 0987:
                    preco = 5.32;
                break;

                case 7623:
                    preco = 6.45;
                break;
            }

            double precoTotal = qtd * preco;

            Console.WriteLine("Preço total: R$ " + precoTotal.ToString("F2", CI));
            
 }
 }
} 
