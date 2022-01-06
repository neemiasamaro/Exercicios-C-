/*Faça um algoritmo que calcule e exiba o salário reajustado 
 * de dez funcionários de acordo com a seguinte regra: Salário até 300, 
 * reajuste de 50%; Salários maiores que 300, reajuste de 30%.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Exercicio04
    {
        static void Main(string[] args)
        {
            Double salario;
            Double reajuste;
            for(int i = 1;i <= 10;i++)
            {
                Console.Write("Insira o salário do " + i + "º funcionário: R$ ");
                salario = double.Parse(Console.ReadLine());
                if(salario < 300)
                {
                    reajuste = salario + (salario * 0.5);
                    Console.WriteLine("Salário Reajustado: R$ " + reajuste);
                }
                else
                {
                    reajuste = salario + (salario * 0.3);
                    Console.WriteLine("Salário Reajustado: R$ " + reajuste);
                }
            }
            Console.ReadKey();
        }
    }
}
