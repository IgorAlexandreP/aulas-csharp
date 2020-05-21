using System;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco bc = new Banco();
            Console.WriteLine("Entre o numero da conta: ");
            bc.NumeroConta();
            Console.WriteLine("Entre o nome do titular da conta: ");
            bc.NomeC = Console.ReadLine();
            Console.WriteLine("Deseja fazer um deposito inicial? (s/n): ");
            char x = Convert.ToChar(Console.ReadLine());
            bc.Vdepoini(x);
            Console.WriteLine("Dados da conta: ");
            bc.Verifica();

            Console.WriteLine("Digite o valor para Deposito: ");
            bc.Depositar();
            Console.WriteLine("Dados da conta atualizados: ");
            bc.Verifica();

            Console.WriteLine("Entre um valor para saque: ");
            bc.Sacar();
            Console.WriteLine("Dados da conta atualizados: ");
            bc.Verifica();
            Console.ReadKey();

        }
    }
}
