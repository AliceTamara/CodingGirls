namespace CodingGirlsProject
{
    internal class TV
    {
        public string Marca { get; private set; }
        public int CodigoDeSerie { get; private set; }
        public List<Canal> Canais { get; set; }
        public string Status { get; set; }
        public int Volume { get; set; }
        public Canal CanalAtual { get; set; }

        public TV(string marca, int codigoDeSerie, List<Canal> canais, int volume = 25, string status = "desligada")
        {
            Marca = marca;
            CodigoDeSerie = codigoDeSerie;
            Canais = canais;
            Status = status;
            Volume = volume;
        }
        
        public void AumentarVolume()
        {
            if (!TVEstaLigada())
                return;

            if (Volume + 1 < 100)
                Volume++;
        }

        public void DiminuirVolume()
        {
            if (!TVEstaLigada())
                return;

            if (Volume - 1 > 0)
                Volume--;
        }

        public void LigarTV()
        {
            if (!TVEstaLigada())
                Status = "ligada";
        }

        public void DesligarTV()
        {
            if (TVEstaLigada())
                Status = "desligada";
        }

        public void MudarCanal(int canal)
        {
            if (!TVEstaLigada())
                return;
            if (Canais.Any(_ => _.Numero == canal))
                CanalAtual = Canais.Where(_ => _.Numero == canal).FirstOrDefault();
            else
                Console.WriteLine("Canal não existe");
        }

        private bool TVEstaLigada() => 
            Status.Equals("ligada");
    }
}