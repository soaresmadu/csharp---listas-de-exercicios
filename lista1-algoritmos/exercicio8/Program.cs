using System;
using System.Globalization;

namespace exercicio8 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double a, b, c, d, e, f;

            Console.Write("Valor de a: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de b: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de c: ");
            c = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de d: ");
            d = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de e: ");
            e = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de f: ");
            f = double.Parse(Console.ReadLine(), CI);

            double x = ((c*e)-(b*f)) / ((a*e)-(b*d));
            double y = ((a*f)-(c*d)) /  ((a*e)-(b*d));
            
            Console.WriteLine("x = " + x.ToString("F2", CI));
            Console.WriteLine("y = " + y.ToString("F2", CI));
 }
 }
} 
