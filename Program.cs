using CodingGirlsProject;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            Exercicio5();
        }

        static void Exercicio1()
        {
            Console.WriteLine("-----Exercicio 1-----");
            new JogoDaVelha().Iniciar();
        }

        static void Exercicio2()
        {

            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu cargo: ");
            var cargo = Console.ReadLine();

            Console.WriteLine("Digite seu salario atual: ");
            var salarioMensal = Convert.ToDouble(Console.ReadLine());

            var empregados = new Empregados(nome, cargo, salarioMensal);

            empregados.ZerarSalarioQuandoNegativo();
            empregados.AumentarSalario();
            Console.WriteLine($"Seu salario corrigido será: {empregados.SalarioMensal}");
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            Console.Write("Digite o Numero do Produto: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a descrição do produto: ");
            string descricaoProduto = Console.ReadLine();

            Console.Write("Digite a Quantidade que deseja comprar: ");
            int quantidadeComprada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o preço unitario do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            var faturaLojaSuprimentosInformatica = new FaturaLojaSuprimentosInformatica(numero, descricaoProduto, quantidadeComprada, preco);

            Console.WriteLine($"O valor total da sua compra é: R${faturaLojaSuprimentosInformatica.CalcularTotalDaFatura()}");
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");

            var sorteio = new Sorteio();

            var numeroIgual = false;

            do
            {
                Console.WriteLine("digite um numero entre 0 e 1000: ");
                var numero = Convert.ToInt32(Console.ReadLine());
                numeroIgual = sorteio.AdivinharNumero(numero);
            } while (!numeroIgual);

            
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");

            Console.WriteLine("Digite o nome completo: ");
            var manipuladorString = new ManipuladorStrings();
            var nome = Console.ReadLine();
            var nomeCompleto = nome;

            Console.Write("Nome Abreviado: ");
            Console.WriteLine(manipuladorString.GerarAbreviacaoDeNome(nomeCompleto));

            Console.Write("nome invertido: ");
            Console.WriteLine(manipuladorString.InverterString(nome));

            manipuladorString.ContarVogaisEConsoantes(nome);
            
        }
    }
}