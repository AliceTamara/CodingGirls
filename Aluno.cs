namespace CodingGirlsProject
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double NotaProva1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho { get; set; }
        public double NotaProvaFinal { get; set; }

        public void CalcularMedia()
        {
            var media = (NotaProva1 + NotaProva2 + NotaTrabalho + NotaProvaFinal) / 4;
            Console.WriteLine(media);
        }

        public void CalcularNotaProvaFinalNecessaria()
        {
            var notaDeCorte = 7;
            var notaMinimaParaProvaFinal = notaDeCorte * 4 - NotaProva1 - NotaProva2 - NotaTrabalho;
            Console.WriteLine(notaMinimaParaProvaFinal);
        }
    }
}