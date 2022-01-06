//1 - Elabore um algoritmo que calcule a idade média de 5 alunos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            Double idade = 0;
            Double media;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite a idade do " + i + "º aluno");
                idade += Convert.ToDouble(Console.ReadLine());
            }
            media = idade / 5;
            Console.WriteLine("A média de idade doos 5 alunos é de" + media + " anos");
            Console.ReadKey();
        }
    }
}
