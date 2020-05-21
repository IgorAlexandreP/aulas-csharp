using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> alunosA = new HashSet<int>();
            Console.WriteLine("O curso A possui quantos alunos? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Digite o código do aluno " + i + ": ");
                int j = int.Parse(Console.ReadLine());
                alunosA.Add(j);
            }

            HashSet<int> alunosB = new HashSet<int>();
            Console.WriteLine("O curso B possui quantos alunos? ");
            int y = int.Parse(Console.ReadLine());


            for(int i = 0; i < y; i++)
            {
                Console.WriteLine("Digite o código do aluno " + i + ": ");
                int j = int.Parse(Console.ReadLine());
                alunosB.Add(j);
            }

            HashSet<int> alunosC = new HashSet<int>();
            Console.WriteLine("Quantos alunos tem no curso C? ");
            int z = int.Parse(Console.ReadLine());

            for(int i = 0; i < z; i++)
            {
                Console.WriteLine("Digite o código do aluno " + i + ": ");
                int j = int.Parse(Console.ReadLine());
                alunosC.Add(j);
            }

            HashSet<int> resultado = new HashSet<int>();
            resultado.UnionWith(alunosA);
            resultado.UnionWith(alunosB);
            resultado.UnionWith(alunosC);
            Console.WriteLine("O total de alunos cadastrados é: " + resultado.Count);
            Console.ReadLine();

        }
    }
}
