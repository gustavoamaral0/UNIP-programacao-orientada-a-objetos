using System;
using System.ComponentModel;

namespace Exercicio_2
{
    public static class Program
    {
        public static void Main()
        {
            Conta minhaConta = new Conta();
            minhaConta.Saldo = 100;

            minhaConta.Sacar(10);
            minhaConta.Sacar(50);
            minhaConta.Depositar(10);

            Console.WriteLine("Saldo atual R$ {0}", minhaConta.Saldo);

        }
    }

    public class Conta
    {
        public float Saldo { get; set; }

        public void Sacar(float valor)
        {
            Saldo -= valor;
        }
        public void Depositar(float valor)
        {
            Saldo += valor;
        }
    }
}