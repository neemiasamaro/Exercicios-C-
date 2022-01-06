//2 - Crie um algoritmo que verifique se um número informado é par ou impar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("Este numero é par!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Este numero é impar!");
                Console.ReadKey();
            }

        }
    }
}
