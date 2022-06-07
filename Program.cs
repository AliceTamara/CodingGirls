using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1
            Console.WriteLine("-----Exercicio 1=====");
            string nome = "Alice Tamara Suyama de Santana";
            string endereco = "Rua Maracujá";
            int numeroResidencia = 70;
            int cep = 45312125;
            var telefone = 11988888585;

            Console.WriteLine($"Meu nome completo é: {nome} \nMeu endereço é: {endereco}, {numeroResidencia} \nCEP: {cep} \nMeu Telefone é {telefone}");

            //exercicio2
            Console.WriteLine("\n\n-----Exercicio 2=====");
            string mulherFamosaTecnologia = "Carol Shaw";
            string formacao = "Ciencias da Computação";
            string contribuicao = " foi uma das primeiras mulheres designers e programadoras de jogos na indústria de videogames." +
                "Ela foi capaz de pavimentar o caminho para futuras mulheres no jogo.";

            Console.WriteLine($"A mulher famosa dentro da tecnologia que escolhi foi: {mulherFamosaTecnologia} \nSua formação é: {formacao} " +
                $"\nsua contribuição dentro da tecnologia foi: {contribuicao}");

            //exercicio3
            Console.WriteLine("\n\n-----Exercicio 3-====");

            string musica = "Chão de Giz";
            string compositor = "Zé Ramalho";
            string genero = "MPB";
            string letraDaMusica = "Eu desço dessa solidão" +
                "\nEspalho coisas sobre um chão de giz" +
                "\n" +
                "Há meros devaneios tolos a me torturar" +
                "\n" +
                "Fotografias recortadas" +
                "\n" +
                "Em jornais de folhas amiúde" +
                "\n" +
                "Eu vou te jogar num pano de guardar confetes" +
                "\n" +
                "Eu vou te jogar num pano de guardar confetes" +
                "\n" +
                "Disparo balas de canhão" +
                "\n" +
                "É inútil, pois existe um grão-vizir" +
                "\n" +
                "Há tantas violetas velhas sem um colibri" +
                "\n" +
                "Queria usar, quem sabe" +
                "\n" +
                "Uma camisa de força ou de Vênus" +
                "\n" +
                "Mas não vou gozar de nós apenas um cigarro" +
                "\n" +
                "Nem vou lhe beijar, gastando assim o meu batom" +
                "\n" +
                "Agora pego um caminhão" +
                "\n" +
                "Na lona vou a nocaute outra vez" +
                "\n" +
                "Pra sempre fui acorrentado no seu calcanhar" +
                "\n" +
                "Meus vinte anos de boy, that's over, baby" +
                "\n" +
                "Freud explica" +
                "\n" +
                "Não vou me sujar fumando apenas um cigarro" +
                "\n" +
                "Nem vou lhe beijar, gastando assim o meu batom" +
                "\n" +
                "Quanto ao pano dos confetes, já passou meu carnaval" +
                "\n" +
                "E isso explica porque o sexo é assunto popular" +
                "\n" +
                "No mais, estou indo embora" +
                "\n" +
                "No mais, estou indo embora" +
                "\n" +
                "No mais, estou indo embora" +
                "\n" +
                "No mais";

            Console.WriteLine($"Música: {musica}\n\nLetra: {letraDaMusica}\n\nCompositor: {compositor}\nGenero Musical: {genero}");

            //exercicio4
            Console.WriteLine("\n\n-----Exercicio 4-====");

            Console.WriteLine("Digite seu Nome: ");
            string nome1 = Console.ReadLine();
            var mensagem = "Em qualquer area teremos desafios, mas o maior desafio é vencer as barreiras \nque nós mesmas construimos em nossa mente, então seja corajosa!!!" +
                "\nnão desista de você e do que você acredita, lembre-se sempre de tudo que já enfrentou para estar aqui\ne use tudo isso como degraus pra te empurrar" +
                "\npra cima toda vez que pensar em desistir. \nO medo vem junto, mas você é MULHER! \nVai com medo e sorrindo!";

            Console.WriteLine($"Olá {nome1}\n{mensagem}");


        }

    }
}



