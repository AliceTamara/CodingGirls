using CodingGirlsProject;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            
            
        }


        static void Exercicio1()
        {
            Console.WriteLine("-----Exercicio 1-----");
            int[] numeros = new int[10];
            int[] numerosRecebidosDaMultiplicacao = new int[10];
            var multiplicacao = 5;

            Console.WriteLine("Digite os 10 numeros: ");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                numerosRecebidosDaMultiplicacao[i] = multiplicacao * numeros[i];
            }
            Console.WriteLine("Numeros Recebidos: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine("\nNumeros Recebidos multiplicados por 5: ");
            for (int i = 0; i < numerosRecebidosDaMultiplicacao.Length; i++)
            {
                Console.Write($"{numerosRecebidosDaMultiplicacao[i]} ");
            }
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");
            int[] numerosRecebidos = new int[10];
            int[] numerosPares = new int[10];
            int[] numerosImpares = new int[10];

            var controlePar = 0;
            var controleImpar = 0;

            Console.WriteLine("digite os numeros: ");

            for (int i = 0; i < 10;i++)
            {
                numerosRecebidos[i] = Convert.ToInt32(Console.ReadLine());
                

                if (numerosRecebidos[i] % 2 == 0)
                {
                    numerosPares[controlePar] = numerosRecebidos[i];
                    controlePar++;
                }
                else
                {
                    numerosImpares[controleImpar] = numerosRecebidos[i];
                    controleImpar++;
                }
            }
            Console.WriteLine("Os numeros pares são: ");
            for (int i = 0; i < controlePar; i++)
            {
                Console.Write($"{numerosPares[i]} ");
            }
            Console.WriteLine("\nOs numeros impares são: ");
            for (int i = 0; i < controleImpar; i++)
            {
                Console.Write($"{numerosImpares[i]} ");
            }
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            string[] palavras = new string[5];
            Console.WriteLine("Digite 5 palavras: ");

            string[] palavrasOrdemCumprimento = new string[5];

            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = Console.ReadLine();
            }
            palavrasOrdemCumprimento = palavras.OrderBy(_=>_.Length).ToArray();
            Console.WriteLine("As palavras em ordem de tamanho, do menor para a maior palavra (mais cumprida): ");
            for (int i = 0; i < palavrasOrdemCumprimento.Length; i++)
            {
                Console.WriteLine(palavrasOrdemCumprimento[i]);
            }

        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");
            string jogarNovamente;
            do
            {
                Console.WriteLine("Quantas rodadas você quer jogar: ");
                int numeroDeRodadas = Convert.ToInt32(Console.ReadLine());
                string minhaJogada;
                Random rdm = new Random();
                string jogadaDoComputador;
                string[] jogadas = { "pedra", "papel", "tesoura" };
                int contadorDeVitoriasDoJogador = 0;
                int contadorDeVitoriasDoComputador = 0;


                for (int i = 0; i < numeroDeRodadas; i++)
                {
                    Console.WriteLine("Escolha pedra, papel ou tesoura");
                    minhaJogada = Console.ReadLine();
                    jogadaDoComputador = jogadas[rdm.Next(0, 2)];
                    Console.WriteLine($" O computador jogou {jogadaDoComputador}");

                    if (minhaJogada == "pedra" && jogadaDoComputador == "tesoura")
                    {
                        Console.WriteLine("você ganhou esta rodada!");
                        contadorDeVitoriasDoJogador++;
                    }
                    else if (minhaJogada == "tesoura" && jogadaDoComputador == "papel")
                    {
                        Console.WriteLine("você ganhou esta rodada!");
                        contadorDeVitoriasDoJogador++;
                    }
                    else if (minhaJogada == "papel" && jogadaDoComputador == "pedra")
                    {
                        Console.WriteLine("você ganhou esta rodada!");
                        contadorDeVitoriasDoJogador++;
                    }
                    else if (minhaJogada == "pedra" && jogadaDoComputador == "pedra")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else if (minhaJogada == "tesoura" && jogadaDoComputador == "tesoura")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else if (minhaJogada == "papel" && jogadaDoComputador == "papel")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else
                    {
                        Console.WriteLine("Ponto do Computador!");
                        contadorDeVitoriasDoComputador++;
                    }
                }
                Console.WriteLine($" você fez {contadorDeVitoriasDoJogador} pontos!");
                Console.WriteLine($" o computador fez {contadorDeVitoriasDoComputador}");

                if (contadorDeVitoriasDoComputador > contadorDeVitoriasDoJogador)
                {
                    Console.WriteLine("Computador Venceu!");
                }
                else if (contadorDeVitoriasDoComputador == contadorDeVitoriasDoJogador)
                {
                    Console.WriteLine("Empate!");
                }
                else
                {
                    Console.WriteLine("Parabéns pela vitória!!!");
                }
                Console.WriteLine("voce quer jogar novamente?");
                jogarNovamente = Console.ReadLine();
            } while (jogarNovamente == "sim");
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");
            new JogoDaVelha().Iniciar();

        }
    }
}