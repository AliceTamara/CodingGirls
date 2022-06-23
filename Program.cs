using CodingGirlsProject;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
        }

        static void Exercicio1()
        {
            Console.WriteLine("-----Exercicio 1-----");

            var nome = "Gilberto";
            var apelido = "Giba";
            var numero = 10;
            var pontosDeHabilidade = 90;
            var cartoes = string.Empty;
            var suspenso = false;
            var posicao = "Atacante";

            var jogador = new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao);

            jogador.EstaApto();
            jogador.TornarJogadorSuspenso();
            jogador.CumprirSuspensao();
            jogador.SofrerLesao();

            var nomeTimeCasa= "Brasil";
            var fundacaoTimeCasa = "bradesco";
            var jogadoresTimeCasa = new List<Jogador>()
            {
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao)
            };

            var timeCasa = new Time(nomeTimeCasa, fundacaoTimeCasa, jogadoresTimeCasa);
            timeCasa.ImprimirEscala();

            var nomeTimeVisitante = "Chile";
            var fundacaoTimeVisitante = "Santander";
            var jogadoresTimeVisitante = new List<Jogador>()
            {
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao),
                new Jogador(nome, apelido, numero, pontosDeHabilidade, cartoes, suspenso, posicao)
            };

            var timeVisitante = new Time(nomeTimeVisitante, fundacaoTimeVisitante, jogadoresTimeVisitante);
            timeVisitante.ImprimirEscala();

            var dataDoJogo = DateTime.Now;
            var cidade = "São Bernardo do Campo";
            var placarTimeDaCasa = 10;
            var placarTimeVisitante = 8;

            var jogo = new Jogo(timeCasa, timeVisitante, dataDoJogo, cidade, placarTimeDaCasa, placarTimeVisitante);

            jogo.VerificarEquipeComMaisChanceDeVitoria();
            jogo.GerarLesaoAleatoriaEmAlgumJogador();
            jogo.TerminarPartida();
            jogo.PermitirTreinoAposTermino();
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");
        }
    }
}