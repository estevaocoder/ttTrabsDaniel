using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 2- 
            //Utilizando um List<T>; em uma classe de Produtos com pelo menos 10
            //propriedades, elabore uma aplicação que contenha um menu com três opções,
            //sendo elas, INCLUIR, CONSULTAR e SAIR.O usuário poderá incluir quantos
            //produtos julgar necessário. A Consulta poderá ser feita utilizando 5 opções de
            //propriedade(Ex: Código, Nome, Fornecedor, etc).A opção Sair, além de
            //encerrar a aplicação deve apresentar a quantidade de produtos cadastrados.

            // CRIANDO A LISTA E USANDO AS PROPRIEDADE DA CLASSE DADOS
            List<dados> cadastro = new List<dados>();
            string sair = "nao";
            string ncadastro = "sim";
            int opcao = 0;
            
            while (sair.ToUpper() == "NAO")
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("| [1]-INCLUIR || [2]-CONSULTAR || [3]-SAIR |");
                Console.Write("------------------------------------------------\n> ");
                opcao = Convert.ToInt32(Console.ReadLine());
                
                ncadastro = "sim";
                int cont = 0;

                if (opcao == 1)
                {
                    while(ncadastro.ToUpper() == "SIM")
                    {
                        var cadastrar = new dados();

                        Console.Clear();

                        Console.WriteLine("\n --CADASTRO DE PRODUTOS --\n");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("TOTAL PRODUTOS CAADASTRADOS [" + cadastro.Count() + "]");
                        Console.WriteLine("-----------------------------------------------------\n");

                        cadastrar.id = cont++;

                        Console.Write("[ Nome do Produto ] > ");
                        cadastrar.nome = Console.ReadLine();

                        Console.Write("[ Código do Produto ] > ");
                        cadastrar.codigo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("[ Marca do Produto ] > ");
                        cadastrar.marca = Console.ReadLine();

                        Console.Write("[ Fornecedor do Produto ] > ");
                        cadastrar.fornecedor = Console.ReadLine();

                        Console.Write("[ Validade do Produto EXEMPLO = 123.Dias ] > ");
                        cadastrar.validade = Console.ReadLine();

                        Console.Write("[ Valor do Produto ] > ");
                        cadastrar.valor = Convert.ToInt32(Console.ReadLine());

                        Console.Write("[ Quantidade de Produto ] > ");
                        cadastrar.quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.Write("[ Descrição do Produto ] > ");
                        cadastrar.descricao = Console.ReadLine();

                        Console.Write("[ Tamanho do Produto || EXMPLO: AlturaXLargura [1.60x1.10] ]  > ");
                        cadastrar.tamanho = Console.ReadLine();

                        Console.Write("[ Embalagem do Produto ] > ");
                        cadastrar.embalagem = Console.ReadLine();

                        Console.WriteLine("CADASTRADO COM SUCESSO!!");

                        Console.Write("\n~[ DESEJA CADASTRAR NOVAMENTE [SIM] OU [NAÕ] ] > ");
                        ncadastro = Console.ReadLine();

                        cadastro.Add(cadastrar);

                    }
                }

                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.Write("\n -- CONSULTA DE PRODUTOS --\n");
                    Console.Write("\n[1]- Consulta pelo Código \n[2]- Consulta pelo Nome\n[3]- Consulta pelo Fornecdor\n[4]- Consulta pelo Tamanho\n[5]- Consulta Pelo Vencimento\n> ");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    if (opcao2 == 1)
                    {
                        Console.Write("[ Digite o Código do Produto ] > ");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        foreach (var acesso in cadastro)
                        {
                            if (codigo == acesso.codigo)
                            {
                                Console.Clear();
                                Console.WriteLine(" CONSULTA EFETUADA COM SUCESSO \n");
                                Console.WriteLine("[ ID ] : " + acesso.id );
                                Console.WriteLine("[ Código do Produto ] : " + acesso.codigo );
                                Console.WriteLine("[ Nome do Produto ] : " + acesso.nome );
                                Console.WriteLine("[ Fornecedor ] : " + acesso.fornecedor  );
                                Console.WriteLine("[ Validade do Produto ] : " + acesso.validade );
                                Console.WriteLine("[ Valor R$] : " + acesso.valor );
                                Console.WriteLine("[ Quantidade ] : " + acesso.quantidade );
                                Console.WriteLine("[ Descricao ] : " + acesso.descricao );
                                Console.WriteLine("[ Marca ] : " + acesso.marca );
                                Console.WriteLine("[ Tamanho ] : " + acesso.tamanho );
                                Console.WriteLine("[ Embalagem ] : " + acesso.embalagem );
                            }
                            else
                            {
                                Console.Write("!!! CODIGO NAO ENCONTRADO !!! \n");
                            }
                        }
                    }
                    if (opcao2 == 2)
                    {
                        Console.Write("[ Digite o Nome do Produto ] > ");
                        string nome = Console.ReadLine();

                        foreach (var acesso in cadastro)
                        {
                            if (nome == acesso.nome)
                            {
                                Console.Clear();
                                Console.WriteLine(" CONSULTA EFETUADA COM SUCESSO \n");
                                Console.WriteLine("[ ID ] : " + acesso.id);
                                Console.WriteLine("[ Código do Produto ] : " + acesso.codigo);
                                Console.WriteLine("[ Nome do Produto ] : " + acesso.nome);
                                Console.WriteLine("[ Fornecedor ] : " + acesso.fornecedor );
                                Console.WriteLine("[ Validade do Produto ] : " + acesso.validade);
                                Console.WriteLine("[ Valor R$ ] : " + acesso.valor  );
                                Console.WriteLine("[ Quantidade ] : " + acesso.quantidade);
                                Console.WriteLine("[ Descricao ] : " + acesso.descricao);
                                Console.WriteLine("[ Marca ] : " + acesso.marca);
                                Console.WriteLine("[ Tamanho ] : " + acesso.tamanho);
                                Console.WriteLine("[ Embalagem ] : " + acesso.embalagem);
                            }
                            else
                            {
                                Console.Write("!!! NOME DO PRODUTO NAO ENCONTRADO !!! \n");
                            }
                        }
                    }
                    if (opcao2 == 3)
                    {
                        Console.Write("[ Digite o nome do Fornecedor ] > ");
                        string fornecedor = Console.ReadLine();

                        foreach (var acesso in cadastro)
                        {
                            if (fornecedor == acesso.fornecedor)
                            {
                                Console.Clear();
                                Console.WriteLine(" CONSULTA EFETUADA COM SUCESSO \n");
                                Console.WriteLine("[ ID ] : " + acesso.id);
                                Console.WriteLine("[ Código do Produto ] : " + acesso.codigo);
                                Console.WriteLine("[ Nome do Produto ] : " + acesso.nome);
                                Console.WriteLine("[ Fornecedor ] : " + acesso.fornecedor );
                                Console.WriteLine("[ Validade do Produto ] : " + acesso.validade);
                                Console.WriteLine("[ Valor R$ ] : " + acesso.valor );
                                Console.WriteLine("[ Quantidade ] : " + acesso.quantidade);
                                Console.WriteLine("[ Descricao ] : " + acesso.descricao);
                                Console.WriteLine("[ Marca ] : " + acesso.marca);
                                Console.WriteLine("[ Tamanho ] : " + acesso.tamanho);
                                Console.WriteLine("[ Embalagem ] : " + acesso.embalagem);
                            }
                            else
                            {
                                Console.Write("!!! FORNECEDOR NAO ENCONTRADO !!! \n");
                            }
                        }
                    }
                    if (opcao2 == 4)
                    {
                        Console.Write("[ Digite o Tamanho EXEMPLO 1x2 ] > ");
                        string tamanho = Console.ReadLine();

                        foreach (var acesso in cadastro)
                        {
                            if (tamanho == acesso.tamanho)
                            {
                                Console.Clear();
                                Console.WriteLine(" CONSULTA EFETUADA COM SUCESSO \n");
                                Console.WriteLine("[ ID ] : " + acesso.id);
                                Console.WriteLine("[ Código do Produto ] : " + acesso.codigo);
                                Console.WriteLine("[ Nome do Produto ] : " + acesso.nome);
                                Console.WriteLine("[ Fornecedor ] : " + acesso.fornecedor);
                                Console.WriteLine("[ Validade do Produto ] : " + acesso.validade);
                                Console.WriteLine("[ Valor R$ ] : " + acesso.valor);
                                Console.WriteLine("[ Quantidade ] : " + acesso.quantidade);
                                Console.WriteLine("[ Descricao ] : " + acesso.descricao);
                                Console.WriteLine("[ Marca ] : " + acesso.marca);
                                Console.WriteLine("[ Tamanho ] : " + acesso.tamanho);
                                Console.WriteLine("[ Embalagem ] : " + acesso.embalagem);
                            }
                            else
                            {
                                Console.Write("!!! TAMANHO NAO ENCONTRADO !!! \n");
                            }
                        }
                    }
                    if (opcao2 == 5)
                    {
                        Console.Write("[ Digite o Vencimento EXEMPLO 10.Dias ] > ");
                        string vencimento = Console.ReadLine();

                        foreach (var acesso in cadastro)
                        {
                            if (vencimento == acesso.validade)
                            {
                                Console.Clear();
                                Console.WriteLine(" CONSULTA EFETUADA COM SUCESSO \n");
                                Console.WriteLine("[ ID ] : " + acesso.id);
                                Console.WriteLine("[ Código do Produto ] : " + acesso.codigo);
                                Console.WriteLine("[ Nome do Produto ] : " + acesso.nome);
                                Console.WriteLine("[ Fornecedor ] : " + acesso.fornecedor);
                                Console.WriteLine("[ Validade do Produto ] : " + acesso.validade);
                                Console.WriteLine("[ Valor R$ ] : " + acesso.valor);
                                Console.WriteLine("[ Quantidade ] : " + acesso.quantidade);
                                Console.WriteLine("[ Descricao ] : " + acesso.descricao);
                                Console.WriteLine("[ Marca ] : " + acesso.marca);
                                Console.WriteLine("[ Tamanho ] : " + acesso.tamanho);
                                Console.WriteLine("[ Embalagem ] : " + acesso.embalagem);
                            }
                            else
                            {
                                Console.Write("!!! VENCIMENTO NAO ENCONTRADO !!! \n");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("OPCAO INVALIDA ");
                    }
                }

                if (opcao == 3)
                {
                    Console.WriteLine("TOTAL DE PRODUTOS CADASTRADOS > " + cadastro.Count );
                    sair = "sim";
                    Console.ReadKey();
                }


            }
        }
    }
}
