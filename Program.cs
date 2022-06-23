using CodingGirlsProject;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
        }

        static void Exercicio1()
        {

            var triangulo = new Triangulo();
            triangulo.CalcularArea();

            var circulo = new Circulo();
            circulo.CalcularArea();

            var quadrado = new Quadrado();
            quadrado.CalcularArea();

            var trapezio = new Trapezio();
            trapezio.CalcularArea();

            var losango = new Losango();
            losango.CalcularArea();
        }

        static void Exercicio2()
        {
            Console.WriteLine("-----Exercicio 2-----");
        }

        static void Exercicio3()
        {
            Console.WriteLine("-----Exercicio 3-----");
        }

        static void Exercicio4()
        {
            Console.WriteLine("-----Exercicio 4-----");
        }

        static void Exercicio5()
        {
            Console.WriteLine("-----Exercicio 5-----");
        }
    }
}