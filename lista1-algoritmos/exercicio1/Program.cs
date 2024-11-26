
using System;
using System.Globalization;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x1, x2, y1, y2;

            Console.WriteLine("Digite as coordenadas do ponto 1 (x1, y1): ");
            x1 = double.Parse(Console.ReadLine(), CI);
            y1 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite as coordenadas do ponto 2 (x2, y2): ");
            x2 = double.Parse(Console.ReadLine(), CI);
            y2 = double.Parse(Console.ReadLine(), CI);

            double distancia = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));

            Console.WriteLine("A distância entre os pontos é: " + distancia.ToString("F2", CI));
            
 }
 }
} 
