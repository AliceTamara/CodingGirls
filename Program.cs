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
            double valorRecebido = 576.73;
            var contadorNota100 = 0;
            var contadorNota50 = 0;
            var contadorNota20 = 0;
            var contadorNota10 = 0;
            var contadorNota5 = 0;
            var contadorNota2 = 0;

            for (int i = 0; valorRecebido >= 2; i++)
            {
                if (valorRecebido > 100)
                {
                    valorRecebido -= 100;
                    contadorNota100++;
                }
                else if (valorRecebido > 50)
                {
                    valorRecebido -= 50;
                    contadorNota50++;
                }
                else if (valorRecebido > 20)
                {
                    valorRecebido -= 20;
                    contadorNota20++;
                }
                else if (valorRecebido > 10)
                {
                    valorRecebido -= 10;
                    contadorNota10++;
                }
                else if (valorRecebido > 5)
                {
                    valorRecebido -= 5;
                    contadorNota5++;
                }
                else if (valorRecebido > 2)
                {
                    valorRecebido -= 2;
                    contadorNota2++;
                }
            }

            Console.WriteLine($"{contadorNota100} notas de R$100,00");
            Console.WriteLine($"{contadorNota50} notas de R$50,00");
            Console.WriteLine($"{contadorNota20} notas de R$20,00");
            Console.WriteLine($"{contadorNota10} notas de R$10,00");
            Console.WriteLine($"{contadorNota5} notas de R$5,00");
            Console.WriteLine($"{contadorNota2} notas de R$2,00");
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");

            int valor1 = 7;
            int valor2 = 14;
            int valor3 = 106;

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine($"O valor {valor1} é o maior!");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine($"O valor {valor2} é o maior!");
            }
            else
            {
                Console.WriteLine($"O valor {valor3} é o maior!");
            }
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            double nota1 = 7;
            double nota2 = 8;
            double nota3 = 3;

            var somaNotas = nota1 + nota2 + nota3;
            var mediaNotas = somaNotas / 3;

            if (mediaNotas >= 7)
            {
                Console.WriteLine($"O Aluno tirou {mediaNotas:F1} e foi Aprovado.");
            }
            else
            {
                Console.WriteLine($"O Aluno tirou {mediaNotas:F1} e foi Reprovado.");
            }
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");

            double nota1 = 10;
            double nota2 = 8;
            double nota3 = 9;

            var somaNotas = nota1 + nota2 + nota3;
            var mediaNotas = somaNotas / 3;

            if (mediaNotas >= 9)
            {
                Console.WriteLine($"O Aluno tirou A. Parabéns!");
            }
            else if (mediaNotas >= 8)
            {
                Console.WriteLine($"O Aluno tirou B. Parabéns!");
            }
            else if (mediaNotas >= 7)
            {
                Console.WriteLine($"O Aluno tirou C. Pode Melhorar!");
            }
            else if (mediaNotas >= 6)
            {
                Console.WriteLine($"O Aluno tirou D.Precisa estudar mais!");
            }
            else if (mediaNotas < 6)
            {
                Console.WriteLine($"O Aluno tirou F. Reprovado!");
            }

        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");

            Console.WriteLine("Digite seu salário: ");
            double valorSalario = Convert.ToDouble(Console.ReadLine());
            double percentual;
            double valorSalarioAtualizado;
            double reajusteValor;

            if (valorSalario >= 2000.00)
            {
                percentual = 4;
            }
            else if (valorSalario >= 1200.01)
            {
                percentual = 7;
            }
            else if (valorSalario >= 801)
            {
                percentual = 10;
            }
            else if (valorSalario >= 401)
            {
                percentual = 12;
            }
            else
            {
                percentual = 15;
            }

            reajusteValor = valorSalario * percentual / 100;
            valorSalarioAtualizado = reajusteValor + valorSalario;
            Console.WriteLine($"Novo salario {valorSalarioAtualizado.ToString("F2")} \nReajuste de {reajusteValor.ToString("F2")} \nEm Percentual {percentual}%");
        }
    }
}