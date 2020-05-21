using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados serão registrados? ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Listagem> list = new List<Listagem>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Listagem(id, nome, salario));
                Console.WriteLine("");
            }
            Console.WriteLine("Dados registrados: ");
            foreach (Listagem obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Qual o ID do funcionario que você deseja dar o aumento? ");
            int procurarID = Convert.ToInt32(Console.ReadLine());

            Listagem emp = list.Find(x => x.ID == procurarID);

            if(emp != null)
            {
                Console.WriteLine("Quanto você deseja dar aumento (em porcentagem): ");
                double porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Aumento(porcentagem);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Dados Atualizados após o aumento: ");
                foreach (Listagem obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
            else
            {
                Console.WriteLine("Este número de ID digitado não existe.");
            }
        }
    }
}
