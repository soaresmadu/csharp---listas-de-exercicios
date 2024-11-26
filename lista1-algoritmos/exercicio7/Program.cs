using System;
using System.Globalization;

namespace exercicio7 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double custoFabrica;

            Console.Write("Digite o valor do custo de fábrica: ");
            custoFabrica = double.Parse(Console.ReadLine(), CI);

            double valorDistribuidor = custoFabrica * 28 / 100;
            double valorImpostos = custoFabrica * 45 / 100;

            double custoConsumidor = custoFabrica + valorDistribuidor + valorImpostos;

            Console.WriteLine("CUSTO TOTAL AO CONSUMIDOR: " + custoConsumidor.ToString("F2", CI));

            
               
 }
 }
} 
