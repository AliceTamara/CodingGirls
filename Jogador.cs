namespace CodingGirlsProject
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Numero { get; set; }
        public double PontosDeHabilidade { get; set; }
        public string Cartoes { get; set; }
        public bool Suspenso { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string apelido, int numero, double pontosDeHabilidade, 
            string cartoes, bool suspenso, string posicao)
        {
            Nome = nome;
            Apelido = apelido;
            Numero = numero;

            if (pontosDeHabilidade > 100)
                throw new Exception("Pontos de habilidade nao podem ser maior que 100.");

            PontosDeHabilidade = pontosDeHabilidade;
            Cartoes = cartoes;
            Suspenso = suspenso;
            Posicao = posicao;
        }
        
        public bool EstaApto() =>
            !Suspenso;

        public void TornarJogadorSuspenso()
        {
            if (EstaApto())
                Suspenso = true;
        }

        public void CumprirSuspensao()
        {
            if (Suspenso)
                Suspenso = false;
        }

        public void SofrerLesao()
        {
            var lesoes = new Dictionary<string, double>
            {
                {"Dor de Cabeca", 1 },
                {"Torcicolo", 2 },
                {"Distensao Muscular", 3 },
                {"Dor na mão", 4 },
                {"Estiramento", 5 },
                {"Torcao", 10 },
                {"Braco Quebrado", 15}
            };
            
            var rdm = new Random().Next(0, lesoes.Count - 1);
            var lesoesKeys = lesoes.Keys.ToArray();
            var lesaoKeyRandom = lesoesKeys[rdm];
            
            PontosDeHabilidade -= lesoes[lesaoKeyRandom];
        }

        public void Treinar()
        {
            if(PontosDeHabilidade == 100)
                throw new Exception("Pontos de habilidade nao podem ser maior que 100.");

            PontosDeHabilidade++;
        }
    }
}