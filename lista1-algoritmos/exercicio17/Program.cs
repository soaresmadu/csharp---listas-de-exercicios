using System;
using System.Globalization;

namespace exercicio17 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o seu sexo (M/F): ");
            char sexo = char.Parse(Console.ReadLine());

            double pesoIdeal = 0;

            if (sexo == 'M' || sexo =='m') {
                pesoIdeal = (altura*72.7)-58;
            } else if (sexo == 'F' || sexo == 'f') {
                pesoIdeal = (altura*62.1)-44.7;
            }

            Console.WriteLine("Peso ideal = " + pesoIdeal.ToString("F2", CI) + " kg");

 }
 }
} 