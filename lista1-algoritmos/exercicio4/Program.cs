
using System;

namespace exercicio4 {
    class Program {
        static void Main(string[] args) {
            
            int idadeDias;

            Console.Write("Digite a sua idade em dias: ");
            idadeDias = int.Parse(Console.ReadLine());

            int anos = (idadeDias/365);
            int resto = (idadeDias%365);

            int meses = resto / 30;
            int dias = resto % 30;

            Console.WriteLine("A idade é: "+anos+" anos, " + meses+" meses e " +dias+ " dias.");
            
 }
 }
} 
