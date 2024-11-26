
using System;

namespace exercicio3 {
    class Program {
        static void Main(string[] args) {
            
            int anos, meses, dias, totalEmDias;

            Console.Write("Anos: ");
            anos = int.Parse(Console.ReadLine());
            Console.Write("Meses: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Dias: ");
            dias = int.Parse(Console.ReadLine());

            totalEmDias = (anos * 365) + (meses*30) + dias;

            Console.WriteLine("A idade total em dias é: " + totalEmDias);
            
 }
 }
} 