using System;
using System.Globalization;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 5, 20);
            DateTime d2 = new DateTime(2020, 5, 20, 17, 45, 3);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2020-05-20");
            DateTime d7 = DateTime.Parse("2020-05-20 13:05:58");
            DateTime d8 = DateTime.Parse("05/20/2020");
            DateTime d9 = DateTime.ParseExact("2020-05-20", "yyyy-MM-dd", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);


        }
    }
}
