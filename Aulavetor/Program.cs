using System;

namespace Aulavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digita um valor ai: ");
            n = Convert.ToInt32(Console.ReadLine());

            Aula[] vect = new Aula[n];

            for(int i = 0; i < n; i++)
            {
                string nome;
                double price;
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o preço: ");
                price = Convert.ToDouble(Console.ReadLine());
                vect[i] = new Aula { Nome = nome, Valor = price };
            }

        }
    }
}
