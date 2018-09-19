using System;

namespace ProjetoModulo7OOB
{
    public class Carro
    {
        public String cor;
        public String modelo;
        public double velocidadeMaxima;
        public int qtdRodas;
        public int qtdPortas;

        public string Ligar()
        {
            return "Carro Ligado";
        }
        public string Acelerar()
        {
            return "Carro acelerou";
        }
    }
}
