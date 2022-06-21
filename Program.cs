using CodingGirlsProject;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            //Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
        }

        static void Exercicio1()
        {
            Console.WriteLine("-----Exercicio 1-----");
            var tamara = new Aluno(1, "Alice", 100);
            var filipe = new Aluno(2, "Filipe", 100);

            filipe.AdicionarNotas(new double[] {10, 10, 10, 10});
            tamara.AdicionarNotas(new double[] {10, 10, 10, 10});
            
            tamara.Cadastrar(filipe);

            var consultaFilipe = tamara.ConsultarPorCodigo(2);
            var consultaTodos = tamara.Consultar();
        }

        static void Exercicio2()
        {

            
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");

            Console.WriteLine("Digite seu nome completo: ");
            var titular = Console.ReadLine();

            Console.WriteLine("Digite o numero da conta: ");
            var conta = Convert.ToInt32(Console.ReadLine());

            var contaBancaria = new ContaBancaria(titular, conta);

            Console.WriteLine("Gostaria de alterar o titular da conta? S - para sim e N - para não)");
            var respostaAlteracaoTitular = Console.ReadLine();

            if (respostaAlteracaoTitular.ToUpper().FirstOrDefault() == 'S')
            {
                Console.WriteLine("Insira o novo nome do titular: ");
                var novoTitular = Console.ReadLine();
                contaBancaria.AlterarTitular(novoTitular);
            }

            Console.WriteLine("Gostaria de realizar um depósito? S - para sim e N - para não)");
            var respostaDeposito = Console.ReadLine();

            if (respostaDeposito.ToUpper().FirstOrDefault() == 'S')
            {
                Console.WriteLine("Insira o valor do depósito: ");
                var novoDeposito = Convert.ToDouble(Console.ReadLine());
                contaBancaria.Deposito(novoDeposito);
            }

            Console.WriteLine("Gostaria de realizar um saque? S - para sim e N - para não)");
            var respostaSaque = Console.ReadLine();

            if (respostaSaque.ToUpper().FirstOrDefault() == 'S')
            {
                Console.WriteLine("Insira o valor do saque: ");
                var novoSaque = Convert.ToDouble(Console.ReadLine());
                contaBancaria.Saque(novoSaque);
            }
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");

            Console.WriteLine("Cadastro do seu humano: ");

            Console.WriteLine("Digite o nome: ");
            var nomeDono = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            var telefone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o endereço: ");
            var endereco = Console.ReadLine();

            var dono = new Dono(nomeDono, telefone, endereco);

            Console.WriteLine("Cadastro PET: ");
            Console.WriteLine("Digite o nome do seu pet: ");
            var nomeAnimal = Console.ReadLine();

            Console.WriteLine("Digite a especie: ");
            var especie = Console.ReadLine();

            Console.WriteLine("Dgite a cor: ");
            var cor = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            var idadeAnimal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alguma observação? Digite aqui: ");
            var observacoes = Console.ReadLine();

            var animal = new Animal(nomeAnimal, especie, cor,
            idadeAnimal, observacoes, dono);
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");

            var canais = new List<Canal>()
            {
                new Canal(1, "globo"),
                new Canal(2, "sbt"),
                new Canal(3, "band"),
                new Canal(4, "cultura"),
                new Canal(5, "record"),
                new Canal(6, "rede vida"),
                new Canal(7, "polishop")
            };

            string marca = "Samsung";
            int codigoDeSerie = 123456789;
            
            var tv = new TV(marca, codigoDeSerie, canais);

            Console.WriteLine($"A TV estava {tv.Status}");
            tv.LigarTV();
            Console.WriteLine($"A TV esta agora {tv.Status}");

            tv.AumentarVolume();
            tv.DiminuirVolume();
            tv.MudarCanal(2);

            Console.WriteLine($"O canal atual é {tv.CanalAtual.Nome}");
        }
    }
}