namespace CodingGirlsProject
{
    internal class SistemaDeLogin
    {
        private List<Conta> _contas = new List<Conta>();
        
        public void CriacaoDeConta(Conta conta)
        {
            _contas.Add(conta);
        }

        public void AlterarSenha(Conta conta, string novaSenha)
        {
            conta.AlterarSenha(novaSenha);
        }

        public void EntrarNoSistema(Conta conta)
        {
            //if (conta == null)
            //{
            //    Console.WriteLine("Esse usuario não existe!");
            //}
            //else if (conta._senha == null)//Não é possivel acessar field private.
            //{
            //    Console.WriteLine("Senha incorreta!");
            //}
            //else if (conta._login == correto && conta_senha == correto)//Não é possivel acessar field private.
            //{
            //    Console.WriteLine("Bem Vindo ao Sistema!");
            //}
        }
    }
}
