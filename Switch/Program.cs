using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia da semana: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string day;
            
            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-feira";
                    break;
                case 3:
                    day = "Terça-feira";
                    break;
                case 4:
                    day = "Quarta-feira";
                    break;
                case 5:
                    day = "Quinta-feira";
                    break;
                case 6:
                    day = "Sexta-feira";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Dia invaliado";
                    break;
            }

            Console.WriteLine(day);
            
        }
    }
}
