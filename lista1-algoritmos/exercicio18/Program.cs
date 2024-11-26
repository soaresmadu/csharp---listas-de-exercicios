using System;
using System.Globalization;

namespace exercicio18 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite o saldo médio: ");
            double saldoMedio = double.Parse(Console.ReadLine(), CI);

            double credito = 0;

            switch (saldoMedio) {
                case double x when (x >= 0 && x <= 200):
                    credito = 0;
                    Console.WriteLine("Saldo médio: R$ " + saldoMedio.ToString("F2", CI));
                    Console.WriteLine("Crédito: R$ " + credito.ToString("F2", CI));
                    break;

                case double x when (x >= 201 && x <= 400):
                    credito = saldoMedio * 0.20;
                    Console.WriteLine("Saldo médio: R$ " + saldoMedio.ToString("F2", CI));
                    Console.WriteLine("Crédito: R$ " + credito.ToString("F2", CI));
                    break;

                case double x when (x >= 401 && x <= 600):
                    credito = saldoMedio * 0.30;
                    Console.WriteLine("Saldo médio: R$ " + saldoMedio.ToString("F2", CI));
                    Console.WriteLine("Crédito: R$ " + credito.ToString("F2", CI));
                    break;

                case double x when (x > 600):
                    credito = saldoMedio * 0.40;
                    Console.WriteLine("Saldo médio: R$ " + saldoMedio.ToString("F2", CI));
                    Console.WriteLine("Crédito: R$ " + credito.ToString("F2", CI));
                    break;

                default:
                    Console.WriteLine("Valor Inválido.");
                    break;
            }

 }
 }
} 
