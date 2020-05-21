using System;
using System.Collections.Generic;

namespace AulaConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(9);

            b.Add(3);
            b.Add(4);
            b.Add(5);

            foreach(int x in b)
            {
                Console.WriteLine(x);
            }


            //a.ExceptWith(b);

            //a.UnionWith(b);

            a.IntersectWith(b);

            Console.WriteLine("");
            
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }


            /*Console.WriteLine("Digite um valor inteiro: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (b.Contains(n))
            {
                Console.WriteLine("O numero: " + n + " pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine("Não pertence ao conjunto");
            }

            b.Remove(4);

            foreach (int x in b)
            {
                Console.WriteLine(x);
            }*/


            Console.ReadKey();

        }
    }
}
