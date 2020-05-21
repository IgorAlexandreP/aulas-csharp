using System;
using System.Collections.Generic;

namespace AulaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Igor");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");
            list.Insert(3, "Argen");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("O primeiro nome que começa com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("O último nome que começa com A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("O nome Alex está na posição: " + pos1);
            Console.WriteLine("O nome Ana está na posição: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------");
            foreach(string obj2 in list2)
                {
                Console.WriteLine(obj2);
                }

            list.Remove("Alex");
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(0, 1);
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
