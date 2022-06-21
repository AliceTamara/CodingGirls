namespace CodingGirlsProject
{
    internal class Aluno
    {
        public int Codigo { get; private set; }

        private string _nome;
        private double[] _notas;
        private int _frequencia;

        private List<Aluno> _alunos = new List<Aluno>();

        public Aluno(int codigo, string nome, int frequencia)
        {
            Codigo = codigo;
            _nome = nome;
            _frequencia = frequencia;

            _alunos.Add(this);
        }

        public void Cadastrar(Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public Aluno ConsultarPorCodigo(int codigo)
        {
            return _alunos.Where(_ => _.Codigo == codigo).FirstOrDefault();
        }

        public List<Aluno> Consultar()
        {
            return _alunos;
        }

        public void AdicionarNotas(double[] notas)
        {
            _notas = notas;
        }
    }
}
