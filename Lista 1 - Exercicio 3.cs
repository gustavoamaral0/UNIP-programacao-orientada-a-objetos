using System;
using System.Collections.Generic;

namespace Exercicio_3
{
    public static class Program
    {
        public static void Main()
        {
            Cadastro Cliente = new Cadastro();
            Cliente.Nome = "Gustavo Amaral";
            Cliente.Cpf = "123.456.789-0";
            Cliente.Enderecos = new List<Endereco>();

            Endereco end1 = new Endereco();
            end1.Cep = "14804000";

            Endereco end2 = new Endereco();
            end2.Cep = "14804001";

            Cliente.Enderecos.Add(end1);
            Cliente.Enderecos.Add(end2);

            Console.WriteLine("Meu nome é" + Cliente.Nome + "e meu CPF é" + Cliente.Cpf);
            Console.WriteLine("Meus Endereços:");
            foreach(Endereco endereco in Cliente.Enderecos)
            {
                Console.WriteLine(endereco.Cep);
            }
            for(int i = 0; i < Cliente.Enderecos.Count; i++)
            {
                Console.WriteLine(Cliente.Enderecos[i].Cep);
            }

        }
        class Cadastro
        {
            public String Nome { get; set; }
            public String Cpf { get; set; }
            public List <Endereco> Enderecos { get; set; }

        }
        class Endereco
        {
            public String Logradouro { get; set; }
            public String Cep { get; set; }
            public String Numero { get; set; }
        }
    }
}
