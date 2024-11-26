using System;
using System.Globalization;

namespace exercicio23 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Valor de c: ");
            int c = int.Parse(Console.ReadLine());

            double p = 0;
            double area = 0;

            if (a < b+c && b < a+c && c < a+b) {
                p = (a+b+c)/2;
                area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

                Console.WriteLine("Área do triângulo: " + area.ToString("F2", CI));
            } else {
                Console.WriteLine("Os valores não formam um triângulo.");
            }
                                
 }
 }
} 

