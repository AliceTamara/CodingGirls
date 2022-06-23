namespace CodingGirlsProject
{
    internal class Time
    {
        public string Nome { get; set; }
        public string Fundacao { get; set; }
        public  List<Jogador> JogadoresTitulares { get; set; }
        public  List<Jogador> JogadoresReservas{ get; set; }

        public Time(string nome, string fundacao, List<Jogador> jogadores)
        {
            Nome = nome;
            Fundacao = fundacao;
            SelecioneMelhoresJogadores(jogadores);
        }
        
        public void SelecioneMelhoresJogadores(List<Jogador> jogadores)
        {
            var jogadoresOrdenadorPorHabilidade = jogadores.OrderByDescending(_ => _.PontosDeHabilidade);
            JogadoresTitulares = jogadoresOrdenadorPorHabilidade.Take(6).ToList();
            JogadoresReservas = jogadoresOrdenadorPorHabilidade.Skip(6).Take(jogadores.Count - 6).ToList();
        }

        public void ImprimirEscala()
        {
            Console.WriteLine("Os jogadores titulares são: ");
            foreach(var jogadorTitular in JogadoresTitulares)
            {
                Console.WriteLine($"-{jogadorTitular.Nome}, de numero {jogadorTitular.Numero}."); 
            }
        }
    }
}