/* Ler dois valores inteiros para as variáveis A e B, 
 * efetuar a troca dos valores de modo que a 
 * variável A passe a possuir o valor da variável B, 
 * e a variável B passe a possuir o valor da variável A. 
 * Apresentar os valores trocados.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Exercicio07
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int aux;

            Console.Write("Insira um valor inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Insira outro valor inteiro: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de A = {0}\nValor de B = {1}", a, b);

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Valores Trocados: \nValor de A = {0}\nValor de B = {1}", a, b);
            Console.ReadKey();
        }
    }
}
