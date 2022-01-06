/*3 - Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. 
 * O algoritmo deverá ler a idade de 10 pessoas.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            int idade;
            int maiores = 0;
            int i = 1;
            while(i <= 10)
            {
                Console.Write("Insira a idade da " + i + "º pessoa: ");
                idade = int.Parse(Console.ReadLine());
                if (idade >= 18)
                    maiores++;
                i++;
            }
            Console.Write("A quantidade de pessoas que possuem mais de 18 anos é igual a " + maiores);
            Console.ReadKey();
        }
    }
}
