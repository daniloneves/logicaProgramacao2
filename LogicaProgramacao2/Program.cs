using System;
using System.Collections.Specialized;

namespace LogicaProgramacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de dados
            //pilha - Last In, First Out (LIFO)
            //fila - First in, First Out (FIFO)
            //lista - lista não-organizada / não-sequencial



            //Pilha
            int[] numeros = new int[10];

            //Estrutura de atribuição de dados
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);                
            }

            //Fila
            //int[] numeros = new int[10];

            ////Estrutura de atribuição de dados
            //for (int i = 0; i < 10; i++)
            //{
            //    numeros[i] = i;
            //}

            ////Estrutura de impressão de dados

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            //Lista
            //int[] numeros = new int[5];
            //numeros[3] = 1;
            //numeros[4] = 10;
            //Console.WriteLine(numeros[4]);
            //Console.WriteLine(numeros[3]);



            //Estrutra de repetição

            //int resposta = 0;
            //int erro = 0;
            //int count = 1;

            //while (resposta != 2)
            //{
            //    if (count >= 2)
            //        erro++;

            //    Console.WriteLine("Qual o nome do presidente atual do Brasil?");
            //    Console.WriteLine("1 - Fernando Henrique Cardoso");
            //    Console.WriteLine("2 - Jair Bolsonaro");
            //    Console.WriteLine("3 - Lula");
            //    Console.WriteLine("4 - Tancredo Neves");
            //    Console.WriteLine("5 - Dilma");
            //    Console.WriteLine("6 - Castelo Branco");
            //    Console.WriteLine("7 - Sarney");

            //    resposta = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}

            //double nota = 10;

            //if (erro > 0)
            //    nota = nota / erro;

            //Console.WriteLine($"VENCEU! Sua nota é: {nota}");


            //Console.WriteLine("Digite o número inicial:");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o número final:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <= inicial)
            //    Console.WriteLine("Erro: o número FINAL não pode ser menor do que o número INICIAL.");
            //else
            //{
            //    Console.WriteLine("Números ímpares(I) ou números pares(P):");
            //    string tipo = Console.ReadLine();               

            //    switch (tipo.ToLower())
            //    {
            //        case "p":

            //            for (int i = inicial; i <= final; i++)                        
            //                if (i % 2 == 0)
            //                    Console.WriteLine(i);

            //            break;
            //        case "i":

            //            for (int i = inicial; i <= final; i++)
            //                if (i % 2 == 1)
            //                    Console.WriteLine(i);

            //            break;
            //        default:
            //            Console.WriteLine("Você não digitou o tipo de número correto!");
            //            break;
            //    }

            //}

            //int numero = 1;
            //while (numero % 2 == 1) //ímpar
            //{
            //    Console.WriteLine("Digite um número par:");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Obrigado por digitar um número par!");


            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 1) //par
            //    {
            //        Console.WriteLine(i);
            //    }                
            //}


            // While
            //int inteiro = 0;

            //while (inteiro < 10)
            //{
            //    Console.WriteLine(inteiro);
            //    inteiro++;
            //}
        }
    }
}
