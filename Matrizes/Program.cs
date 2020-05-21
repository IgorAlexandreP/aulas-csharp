using System;
using System.Dynamic;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Digite o numero de pesquisa: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (mat[i, j] == x)
                    {

                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {

                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        }

                        if (i > 0)
                        {

                            Console.WriteLine("Up: " + mat[i - 1, j]);

                        }

                        if (j < n - 1)
                        {

                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        }

                        if (i < m - 1)
                        {

                            Console.WriteLine("Down: " + mat[i + 1, j]);

                        }

                    }

                }

            }
        }
    }
}
