using System;
using System.Globalization;

namespace exercicio22 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o cargo do funcionário (101-Gerente, 102-Engenheiro, 103-Técnico): ");
            int cargo = int.Parse(Console.ReadLine());

            double novoSalario = 0;
            double diferenca = 0;

            switch (cargo){
                case 101:
                    novoSalario = salario * 1.10;
                    diferenca = novoSalario - salario;

                break;

                case 102:
                    novoSalario = salario * 1.20;
                    diferenca = novoSalario - salario;
                break;

                case 103:
                    novoSalario = salario * 1.30;
                    diferenca = novoSalario - salario;
                break;

                default:
                    novoSalario = salario * 1.40;
                    diferenca = novoSalario - salario;
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Salário antigo: " + salario.ToString("F2", CI));
            Console.WriteLine("Novo salário: " + novoSalario.ToString("F2", CI));
            Console.WriteLine("Diferença: " + diferenca.ToString("F2", CI));
            
 }
 }
} 
