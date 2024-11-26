using System;
using System.Globalization;

namespace exercicio25 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite o valor de i: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine(), CI);

            switch (i){

                case 1:
                    if (a>b && a>c && b>c) {
                        Console.WriteLine("Ordem crescente: " +c+ " - " + b + " - " +a);
                    }
                    else if (a>b && a>c && c>b) {
                        Console.WriteLine("Ordem crescente: " +b+ " - " + c + " - " +a);
                    }
                    else if (b>a && b>c && a>c) {
                        Console.WriteLine("Ordem crescente: " +c+ " - " + a + "  " +b);
                    }
                    else if (b>a && b>c && c>a) {
                        Console.WriteLine("Ordem crescente: " +a+ " - " + c + " - " +b);
                    }
                    else if (c>a && c>b && a>b) {
                        Console.WriteLine("Ordem crescente: " +b+ " - " + a+ " - " +c);
                    }
                    else if (c>a && c>b && b>a) {
                        Console.WriteLine("Ordem crescente: " +a+ " - " + b+ " - " +c);
                    }
                break;

                case 2:
                    if (a<b && a<c && b<c) {
                        Console.WriteLine("Ordem decrescente: " +c+ " - " + b + " - " +a);
                    }
                    else if (a<b && a<c && c<b) {
                        Console.WriteLine("Ordem decrescente: " +b+ " - " + c + " - " +a);
                    }
                    else if (b<a && b<c && a<c) {
                        Console.WriteLine("Ordem decrescente: " +c+ " - " + a + " - " +b);
                    }
                    else if (b<a && b<c && c<a) {
                        Console.WriteLine("Ordem decrescente: " +a+ " - " + c + " - " +b);
                    }
                    else if (c<a && c<b && a<b) {
                        Console.WriteLine("Ordem decrescente: " +b+ " - " + a+ " - " +c);
                    }
                    else if (c<a && c<b && b<a) {
                        Console.WriteLine("Ordem decrescente: " +a+ " - " + b+ " - " +c);
                    }
                break;

                case 3:
                    if (a<b && a<c && b<c) {
                        Console.WriteLine("Ordem decrescente: " +b+ " - " + c + " - " +a);
                    }
                    else if (a<b && a<c && c<b) {
                        Console.WriteLine("Ordem decrescente: " +c+ " - " + b + " - " +a);
                    }
                    else if (b<a && b<c && a<c) {
                        Console.WriteLine("Ordem decrescente: " +a+ " - " + c + " - " +b);
                    }
                    else if (b<a && b<c && c<a) {
                        Console.WriteLine("Ordem decrescente: " +c+ " - " + a + " - " +b);
                    }
                    else if (c<a && c<b && a<b) {
                        Console.WriteLine("Ordem decrescente: " +a+ " - " + b+ " - " +c);
                    }
                    else if (c<a && c<b && b<a) {
                        Console.WriteLine("Ordem decrescente: " +b+ " - " + a+ " - " +c);
                    }
                break;
            }
                                      
 }
 }
} 
