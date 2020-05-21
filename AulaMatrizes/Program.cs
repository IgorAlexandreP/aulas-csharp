using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace AulaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //estudos matriz
            /*double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));*/

            Console.WriteLine("Quantas linhas e colunas terá a matriz? ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for(int i = 0; i < n ; i++)
            {
                Console.Write(mat[i, i] + " ");
                
            }
            Console.WriteLine("");
            int contagem = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos: " + contagem);
        }
    }
}
