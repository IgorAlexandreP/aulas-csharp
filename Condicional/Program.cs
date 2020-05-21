using System;
using System.Globalization;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                         //true      false
            double desconto = (x < 50) ? x * 0.1 : x * 0.05;

            Console.WriteLine("O desconto que você recebeu é de " + desconto);

        }
    }
}
