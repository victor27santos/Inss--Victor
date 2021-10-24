using System;

namespace Inss__Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double salarioAumento = 0;
            double salarioFinal = 0;
            double aumento = 0;
            double desconto = 0;
            Console.Write("Apresente o salário do empregado:");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Salário inicial do empregado :" + salario + "\n");

            aumento = salario * 0.15;
            salarioAumento = salario + aumento;

            Console.Write("Salário inicial do empregado com aumento: " + salarioAumento + "\n");

            desconto = salarioAumento * 0.8;
            salarioFinal = salarioAumento - desconto;

            Console.Write("Salario do empregado com desconto é:" + salarioFinal + "\n");

            Console.ReadKey();
        }
    }
}
