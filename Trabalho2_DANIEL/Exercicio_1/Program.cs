using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Em um array bidimensional de 10 linhas por 10 colunas do tipo inteiro, solicite ao
            //usuário que preencha este array.Ao final apresente: (1, 0 pto)
            //a.Média Geral
            //b.Maior Número
            //c.Menor Número

            int[,] dados = new int[10, 10];
            int linha = 0;
            int coluna = 0;
            int geral = 0;
            int maior = 0;
            int qmaior = 0;
            int menor = 0;
            int qmenor = 0;
            int cont = 0;

            for (linha=0; linha<4; linha++)
            {
                for (coluna = 0;coluna<4;coluna++)
                {
                    // ADICIONANDO O VALOR NO ARRAY DADOS
                    Console.WriteLine("Valor: "+cont);
                    dados[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    
                    // SOMANDO  OS VALORES PARA FAZER A MEDIA
                    geral = geral + dados[linha, coluna];
                    cont++;
                    Console.WriteLine("Valor Adicionado com Sucesso!!");
                }
            }

            for (linha= 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    if (coluna == 0)
                    {
                        maior = dados[linha, coluna];
                    }
                    else if (maior > dados[linha, coluna])
                    {
                        qmaior= maior;

                    }
                    else
                    {
                        maior = dados[linha, coluna];
                    }
                }
            }

            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    if (coluna == 0)
                    {
                        menor = dados[linha, coluna];
                    }
                    else if (menor < dados[linha, coluna])
                    {
                        qmenor = menor;

                    }
                    else
                    {
                        menor = dados[linha, coluna];
                    }
                }
            }

            Console.WriteLine("Media geral: " + geral/cont);
            Console.WriteLine("Maior Numero: " + qmaior);
            Console.WriteLine("Menor Numero: " + qmenor);

        }
    }
}
