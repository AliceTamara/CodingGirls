namespace CodingGirlsProject
{
    internal class Dono
    {
        public string Nome { get; private set; }
        public int Telefone { get; private set; }
        public string Endereco { get; private set; }

        public Dono(string nome, int telefone, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}