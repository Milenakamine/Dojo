using System;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador griezmann  = new Jogador();
            griezmann.Nome= "Griezmann";
            griezmann.Altura = 1.76f;
            griezmann.Peso = 73f;
            griezmann.Nascimento = DateTime.Parse("21/03/1991");
            griezmann.Posicao = "Atacante";

            Console.WriteLine(griezmann.CalcularIdade());
            Console.WriteLine(griezmann.VerificarAposentadoria());
        }
    }
}
