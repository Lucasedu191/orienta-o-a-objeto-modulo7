using System;

namespace ProjetoModulo7OOB
{
    public class Carro
    {

        public String cor { get; set; }
        public String modelo { get; set; }
        public double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }


        public string Ligar()
        {
            return "Carro Ligado";
        }

        public string Ligar(int velocidade)
        {
            return "Carro Ligado";
        }

        public string Ligar(double vel)
        {
            return "Carro Ligado";
        }


        public string Acelerar()
        {
            return "Carro acelerou";
        }
    }
}
