namespace CodingGirlsProject
{
    internal class Voo
    {
        public DateTime Data { get; set; }

        private const int QuantidadeMaximaDePassageiros = 100;

        private int[] _vagas = PreencherVagas();

        private static int[] PreencherVagas()
        {
            var vagas = new int[QuantidadeMaximaDePassageiros];
            for (int i = 1; i <= QuantidadeMaximaDePassageiros; i++)
            {
                vagas[i-1] = i;
            }
            return vagas;
        }

        public bool OcuparVaga(int cadeira)
        {
            var posicaoCadeiraNoArray = cadeira - 1;
            if (_vagas[posicaoCadeiraNoArray] != 0)
            {
                _vagas[posicaoCadeiraNoArray] = 0;
                return true;
            }
            return false;
        }

        public int VagasLivres()
        {
            var quantidadeDeCadeirasLivres = 0;
            for (int i = 0; i < _vagas.Length; i++)
            {
                if (_vagas[i] != 0)
                    quantidadeDeCadeirasLivres++;
            }
            return quantidadeDeCadeirasLivres;
        }

        public int CadeiraLivre()
        { 
            for (int i = 0;i < _vagas.Length;i++)
            {
                if (_vagas[i] != 0)
                    return _vagas[i];
            }
            return 0;
        }

        public void Ocupa(int cadeira)
        {
            var mensagem = OcuparVaga(cadeira) ?
                "Sua cadeira foi reservada!" :
                "Cadeira ja estava ocupada";

            Console.WriteLine(mensagem);
        }

        public void ImprimirDataHorario() =>
            Console.WriteLine(Data);
    }
}