/*Faça um programa que:
  * -Leia a cotação do dólar
  *- Leia um valor em dólares
  *- Converta esse valor para Real
  *- Mostre o resultado
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Exercicio06
    {
        static void Main(string[] args)
        {
            Double dolar;
            Double valor;
            Double real;

            Console.Write("Insira a cotação do dólar: R$ ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade a ser convertida: $ ");
            valor = double.Parse(Console.ReadLine());

            real = valor * dolar;
            Console.WriteLine("Valor convertido para Real: R$ {0}",real);
            Console.ReadKey();
        }
    }
}
