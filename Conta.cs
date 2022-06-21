namespace CodingGirlsProject
{
    internal class Conta
    {
        private string _login;
        private string _senha;

        public Conta(string login, string senha)
        {
            _login = login;
            _senha = senha;
        }

        public void AlterarSenha(string novaSenha)
        {
            _senha = novaSenha;
        }
    }
}
