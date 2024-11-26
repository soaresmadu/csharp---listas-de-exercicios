using System;
using System.Globalization;

namespace exercicio31 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            //1/1! = 1/1 = 1
            //1/2! = 1/2
            //1/3! = 1/6
            //1/4! = 1/24 

            //3 termos: E = 1 + 1/1 + 1/2
            //4 termos: E = 1 + 1/1 + 1/2 + 1/6
            //5 termos: E = 1 + 1/1 + 1/2 + 1/6 + 1/24

            double E = 1+1+(1.0/2.0);

            Console.WriteLine("Cálculo com 3 termos: " + E.ToString("F6", CI));

            E = 1+1+(1.0/2.0)+(1.0/6.0);
            Console.WriteLine("Cálculo com 4 termos: " + E.ToString("F6", CI));

            E = 1+1+(1.0/2.0)+(1.0/6.0)+(1.0/24.0);
            Console.WriteLine("Cálculo com 5 termos: " + E.ToString("F6", CI));

 }
 }
} 
