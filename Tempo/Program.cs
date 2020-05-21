using System;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);//dia
            TimeSpan t5 = new TimeSpan(1, 3, 23, 30, 321);//dia com milisegundos

            TimeSpan t6 = TimeSpan.FromDays(1.2);
            TimeSpan t7 = TimeSpan.FromHours(1.2);
            TimeSpan t8 = TimeSpan.FromMinutes(1.2);
            TimeSpan t9 = TimeSpan.FromSeconds(1.2);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
        }
    }
}
