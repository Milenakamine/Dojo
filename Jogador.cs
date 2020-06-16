using System;

namespace Dojo
{
    public class Jogador
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Posicao { get; set; }

        public string Nacionalidade { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }

        public DateTime Nascimento  { get; set; }

        public int CalcularIdade(){
            
            int AnoAtual      = Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split(" ")[0] );            
            int AnoNascimento = Int32.Parse( Nascimento.ToString().Split("/")[2].Split(" ")[0] );

            Idade = AnoAtual - AnoNascimento;
            return Idade;
        }

        public string VerificarAposentadoria(){

                CalcularIdade();
                string Retorno = "";
                if(Idade >= 35 && Posicao == "Atacante"){
                    Retorno = "O Atacante tem o direito a aposentadoria.";
                }else if(Idade >= 38 && Posicao == "Meio Campo."){
                    Retorno = "O Meio Campista tem o direito a aposentadoria.";
                }else if(Idade >= 40 && Posicao == "Defensor"){
                    Retorno = "O Defendor tem o direito a aposentadoria.";
                }else{
                    Retorno = "O jogador não tem idade sulficiente para se aposentar.";
                }
                return Retorno;
            }

        //  
        public void MostrarDados(){
            System.Console.WriteLine($"Nome:{Nome}, Posição:{Posicao}, Data de nascimento:{Nascimento}");
        }        

    }
}