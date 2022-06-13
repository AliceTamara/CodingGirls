using CodingGirlsProject;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
        }

        static void Exercicio1()
        {
            Console.WriteLine("-----Exercicio 1-----");

            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite o numero de matricula: ");
            aluno.Matricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a Nota da Primeira Prova: ");
            aluno.NotaProva1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota da Segunda Prova: ");
            aluno.NotaProva2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota do Trabalho: ");
            aluno.NotaTrabalho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nSua média antes da Prova Final é: ");
            aluno.CalcularMedia();

            Console.WriteLine("Para ser Aprovado, sua nota minima na prova final deverá ser: ");
            aluno.CalcularNotaProvaFinalNecessaria();
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");
            var voo = new Voo();

            voo.Data = new DateTime(2022, 08, 22, 13, 30, 00);
            Console.Write("A data e horário do seu vôo: ");
            voo.ImprimirDataHorario();
            
            Console.WriteLine($"Existem {voo.VagasLivres()} vagas livres para este voo");
            Console.WriteLine($"A primeira vaga livre encontrada é a de número {voo.CadeiraLivre()}");

            Console.WriteLine("Selecione a poltrona (de 1 a 100) : ");
            var vagaDesejada = Convert.ToInt32(Console.ReadLine());
            voo.Ocupa(vagaDesejada);
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            var calculadora = new Calculadora();

            Console.WriteLine("Escolha qual operação deseja realizar, sendo: " +
                "\n1 para adicao" +
                "\n2 para subtração" +
                "\n3 para multiplicação" +
                "\n4 para divisão");

            var operacaoEscolhida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var resultado = 0d;

            if (operacaoEscolhida == 1)
                resultado = calculadora.Adicao(num1, num2);
            else if (operacaoEscolhida == 2)
                resultado = calculadora.Subtracao(num1, num2);
            else if (operacaoEscolhida == 3)
                resultado = calculadora.Multiplicacao(num1, num2);
            else
                resultado = calculadora.Divisao(num1, num2);
            
            Console.WriteLine($"O resultado da conta é igual a {resultado}");
        }
    }
}