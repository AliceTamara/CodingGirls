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

            int anoDeNascimento = 0;
            Console.WriteLine("Digite seu ano de nascimento(deverá conter 4 digitos): ");
            anoDeNascimento = Convert.ToInt32(Console.ReadLine());

            var anoAtual = DateTime.Today.Year;
            var adicao = anoAtual - anoDeNascimento;

            Console.WriteLine($"O ano de nascimento digitado foi {anoDeNascimento} sua idade é {adicao}");
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");

            Console.WriteLine("Digite 10 numeros inteiros: ");
            var numeros = new int[10];
            var soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + numeros[i];
            }
            Console.WriteLine($"A soma dos numeros digitados é: {soma}");
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            Console.WriteLine("Nome do Funcionário: ");
            var funcionario = Console.ReadLine();

            Console.WriteLine("Digite as horas trabalhadas: ");
            var horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor que Recebe por hora: ");
            var valorPorHora = Convert.ToDouble(Console.ReadLine());

            var multiplicacaoDeHorasTrabalhadasPorValor = horasTrabalhadas * valorPorHora;

            Console.WriteLine($"O funcionário {funcionario}, trabalhou {horasTrabalhadas.ToString("F2")} e tem à receber {multiplicacaoDeHorasTrabalhadasPorValor.ToString("F2")}");
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");
            Console.WriteLine("Digite sua idade:");
            var idade = Convert.ToInt32(Console.ReadLine());

            var calculoEmDias = idade * 365;
            var calculoEmMeses = idade * 12;

            Console.WriteLine($"Sua idade é {idade}, você tem o total de {calculoEmDias} dias vividos e {calculoEmMeses} meses vividos.");
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");

            Console.WriteLine("Digite o valor em Real: ");
            var valorRecebidoEmReal = Convert.ToDouble(Console.ReadLine());

            var valorDolar = 4.86;
            var valorEuro = 5.20;
            var valorLibraEsterlina = 6.12;
            var valorDolarCanadense = 3.88;
            var valorPesoArgentino = 0.040;
            var valorPesoChileno = 0.0059;


            var realParaDolar = valorRecebidoEmReal / valorDolar;
            var realParaEuro = valorRecebidoEmReal / valorEuro;
            var realParaLibraEsterlina = valorRecebidoEmReal / valorLibraEsterlina;
            var realParaDolarCanadense = valorRecebidoEmReal / valorDolarCanadense;
            var realParaPesoArgentino = valorRecebidoEmReal / valorPesoArgentino;
            var realParaPesoChileno = valorRecebidoEmReal / valorPesoChileno;

            Console.WriteLine($"O Valor R${valorRecebidoEmReal} equivale a: " +
                $"\n{realParaDolar} Dólares" +
                $"\n{realParaEuro} Euros" +
                $"\n{realParaLibraEsterlina} Libras Esterlinas" +
                $"\n{realParaDolarCanadense} Dolares Canadenses" +
                $"\n{realParaPesoArgentino} Pesos Argentinos" +
                $"\n{realParaPesoChileno} Pesos Chilenos");
        }
    }
}