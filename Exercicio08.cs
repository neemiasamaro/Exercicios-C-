// Escreva um programa que leia um número inteiro e exiba o seu módulo. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Exercicio08
    {
        static void Main(string[] args)
        {
            int numero;
            int modulo;

            Console.Write("Insira um numero: ");
            numero = int.Parse(Console.ReadLine());
            if(numero >= 0)
            {
                modulo = numero;
                Console.Write("O módulo deste numero é {0}", modulo);
                Console.ReadKey();
            }
            else
            {
                modulo = numero * (-1);
                Console.Write("O módulo deste numero é {0}", modulo);
                Console.ReadKey();
            }
        }
    }
}
