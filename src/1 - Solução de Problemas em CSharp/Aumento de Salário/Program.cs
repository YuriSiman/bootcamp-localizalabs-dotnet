using System;
using System.Globalization;

namespace Aumento_de_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 0) return;

            if (salario == 0)
            {
                reajuste = 0;
                novoSalario = 0;
                percentual = 15;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }

            if (salario > 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", Math.Round(percentual));
            }
        }
    }
}
