namespace CodingGirlsProject
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, int numero, double saldo = 0)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }

        public void Deposito(double valorRecebido)
        {
            Saldo += valorRecebido;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
        }

        public void AlterarTitular(string novoTitular)
        {
            Titular = novoTitular;
        }
    }
}
