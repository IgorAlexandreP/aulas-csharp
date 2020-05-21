using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao
{
    class Banco
    {
        private int Nconta;
        public string NomeC;
        private double Dini, TotalC;

        public void NumeroConta()
        {
            Nconta = Convert.ToInt32(Console.ReadLine());
        }
        public void Saldo()
        {
            Console.WriteLine("Você tem " + TotalC + " na sua conta");
        }
        public void Vdepoini(char x)
        {
            if(x == 's')
            {
                Console.WriteLine("Quanto você deseja depositar?");
                Dini = Convert.ToDouble(Console.ReadLine());
                Depositoinicial();
            }
            else
            {

            }
        }
        public void Depositoinicial()
        {
            TotalC += Dini;
        }
        public void Depositar()
        {
            double deposito = Convert.ToDouble(Console.ReadLine());
            TotalC += deposito;
        }
        public void Sacar()
        {
            double sacar = Convert.ToDouble(Console.ReadLine());
            if(TotalC < sacar)
            {
                Console.WriteLine("Você não tem dinheiro para sacar");
            }
            else
            {
                TotalC -= sacar;
                TotalC -= 5;
            }
            Saldo();
        }
        public void Verifica()
        {
            Console.WriteLine("Conta: " + Nconta + ", Titular: " + NomeC + ", Saldo:" + TotalC);
        }

    }
}
