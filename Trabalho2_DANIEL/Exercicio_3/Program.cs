using System;
using System.Collections.Generic;

namespace Exercicio_3
{
    class Program
    {
        //Utilizando o conceito de SORT elabore uma aplicação que faça o cadastro de
        //fornecedores.Os fornecedores devem possuir o mínimo de 10 propriedades.O
        //usuário poderá cadastrar a quantidade de fornecedores que julgar necessário.
        //Ao final apresente os dados ordenados por ordem alfabética do nome do
        //fornecedor.
        static void Main(string[] args)
        {
            List<dados> cadastro = new List<dados>();

            string sair = "sim";
            while (sair.ToUpper() == "SIM")
            {
                var dado = new dados();

                Console.WriteLine(" -- Cadastro de Fornecedor -- \n");
                
                Console.Write("Codigo: ");
                dado.codigo =Convert.ToInt32(Console.ReadLine());

                Console.Write("CPF/CNPJ: ");
                dado.cpfcnpj = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome/Razao: ");
                dado.nomerazao = Console.ReadLine();

                Console.Write("Nome Fantasia: ");
                dado.nomefantansia = Console.ReadLine();

                Console.Write("Cidade: ");
                dado.cidade = Console.ReadLine();

                Console.Write("Endereco: ");
                dado.endereco = Console.ReadLine();

                Console.Write("Numero: ");
                dado.numero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bairro: ");
                dado.bairro = Console.ReadLine();

                Console.Write("Telefone: ");
                dado.telefone = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cep: ");
                dado.cep = Convert.ToInt32(Console.ReadLine());

                Console.Write("Email: ");
                dado.email = Console.ReadLine();

                cadastro.Add(dado);
                Console.WriteLine("Cadastrado com Sucesso!!\n");

                Console.Write("Deseja Cadastrar Novamente: SIM OU NAO >> ");
                sair = Console.ReadLine();
            }
            cadastro.Sort();
            Console.WriteLine(" -- Fornecedores Cadastrados -- ");
            apresentadados(cadastro);

            Console.ReadKey();

            
        }
        private static void apresentadados(List<dados> cadastro)
        {
            foreach (var item in cadastro)
            {
                Console.WriteLine("| Codigo: " + item.codigo + " | CPF/CNPJ: " + item.cpfcnpj + " | Nome/Razao: " + item.nomerazao + " | Nome Fantasia: " + item.nomefantansia + " | Cidade: " + item.cidade + " | Endereço: " + item.endereco + " | Numero: " + item.numero + " | Bairro: " + item.bairro + " | Telefone: " + item.telefone + " | Cep: " + item.cep + " | Email: " + item.email);
            }
        }
    }
}
