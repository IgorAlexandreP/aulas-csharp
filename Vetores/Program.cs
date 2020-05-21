using System;
using System.ComponentModel.DataAnnotations;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos deseja alugar? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Quartos[] vect = new Quartos[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome de quem vai alugar o quarto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email de quem vai alugar o quarto: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite qual quarto será alugado");
                int room = Convert.ToInt32(Console.ReadLine());
                vect[i] = new Quartos { Nome = nome, Email = email, Room = room };
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome: " + vect[i].Nome);
                Console.WriteLine("Email " + vect[i].Email);
                Console.WriteLine("Quarto alugado: " + vect[i].Room);
                Console.WriteLine("---------------------------------");
            }
            Console.ReadKey();

        }
    }
}
