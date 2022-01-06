using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Exercicio05
    {
        static void Main(string[] args)
        {
            String maiorM;
            Double maiorA;

            String menorM;
            Double menorA;

            String matricula;
            Double altura;

            Console.Write("Informe a matricula do 1º aluno: ");
            matricula = Console.ReadLine();
            Console.Write("Informe a altura do 1º aluno: ");
            altura = double.Parse(Console.ReadLine());

            maiorA = altura;
            menorA = altura;
            maiorM = matricula;
            menorM = matricula;

            for (int i = 2; i < 10; i++)
            {
                Console.Write("Informe a matricula do " + i + "º aluno: ");
                matricula = Console.ReadLine();
                Console.Write("Informe a altura do " + i + "º aluno: ");
                altura = double.Parse(Console.ReadLine());

                if (maiorA < altura)
                {
                    maiorM = matricula;
                    maiorA = altura;
                }

                if (menorA > altura)
                {
                    menorM = matricula;
                    menorA = altura;
                }
            }
            Console.WriteLine("Maior aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", maiorM, maiorA);
            Console.WriteLine("Menor aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", menorM, menorA);
            Console.ReadKey();
        }
    }
}
