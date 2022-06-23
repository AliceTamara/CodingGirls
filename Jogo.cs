namespace CodingGirlsProject
{
    internal class Jogo
    {
        public Time TimeDaCasa { get; set; }
        public Time TimeVisitante { get; set; }
        public DateTime DataDoJogo { get; set; }
        public string Cidade { get; set; }
        public int PlacarTimeDaCasa { get; set; }
        public int PlacarTimeVisitante { get; set; }
        public bool PodeTreinarAposTermino { get; set; }

        private bool _acabouOJogo = false;

        public Jogo(Time timeDaCasa, Time timeVisitante, DateTime dataDoJogo, string cidade, int placarTimeDaCasa, int placarTimeVisitante)
        {
            TimeDaCasa = timeDaCasa;
            TimeVisitante = timeVisitante;
            DataDoJogo = dataDoJogo;
            Cidade = cidade;
            PlacarTimeDaCasa = placarTimeDaCasa;
            PlacarTimeVisitante = placarTimeVisitante;
        }
                   
        public void VerificarEquipeComMaisChanceDeVitoria()
        {
            var qualidadeDaCasa = 0d;
            foreach (var jogadorTitularDoTimeDaCasa in TimeDaCasa.JogadoresTitulares)
            {
                qualidadeDaCasa += jogadorTitularDoTimeDaCasa.PontosDeHabilidade;
            }

            var qualidadeVisitante = 0d;
            foreach (var jogadorTitularDoTimeVisitante in TimeVisitante.JogadoresTitulares)
            {
                qualidadeVisitante += jogadorTitularDoTimeVisitante.PontosDeHabilidade;
            }
            Console.WriteLine(@$"O somatório da qualidade dos jogadores titulares da equipe da casa é {qualidadeDaCasa},
                enquanto que o somatório da qualidade dos jogadores titulares da equipe visitante é {qualidadeVisitante}.");
        }

        public void GerarLesaoAleatoriaEmAlgumJogador()
        {
            var listaUnida = new List<Jogador>(TimeDaCasa.JogadoresTitulares);
            listaUnida.AddRange(TimeVisitante.JogadoresTitulares);

            var rdm = new Random().Next(0, listaUnida.Count - 1);
            var listaUnidaArray = listaUnida.ToArray();
            var lesionadoRandom = listaUnidaArray[rdm];

            lesionadoRandom.SofrerLesao();
        }

        public void TerminarPartida()
        {
            if (PlacarTimeDaCasa == 50 || PlacarTimeVisitante == 50)
                _acabouOJogo = true;
        }

        public void PermitirTreinoAposTermino()
        {
            if (_acabouOJogo)
                PodeTreinarAposTermino = true;
        }
    }
}