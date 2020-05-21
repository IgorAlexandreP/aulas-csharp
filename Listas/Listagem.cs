using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Listas
{
    class Listagem
    {
        public string Nome { get; set; }

        public int ID { get; set; }

        public double Salario { get; set; }


        public Listagem(int id, string name, double salary)
        {
            ID = id;
            Nome = name;
            Salario = salary;
        }

        public void Aumento(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return "ID: " + ID
                + ", "
                + "Nome: " + Nome
                + ", "
                + "Salario: " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
