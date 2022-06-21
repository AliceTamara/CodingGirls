namespace CodingGirlsProject
{
    internal class Animal
    {
        public string NomeAnimal { get; private set; }
        public string Especie { get; private set; }
        public string Cor { get; private set; }
        public int IdadeAnimal { get; private set; }
        public string Observacoes { get; private set; }
        public Dono Dono { get; private set; }

        public Animal(string nomeAnimal, string especie, string cor,
            int idadeAnimal, string observacoes, Dono dono)
        {
            NomeAnimal = nomeAnimal;
            Especie = especie;
            Cor = cor;
            IdadeAnimal = idadeAnimal;
            Observacoes = observacoes;
            Dono = dono;
        }
    }
}
