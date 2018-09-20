using System;

namespace ProjetoModulo7OOB
{

    public class Carro : IVeiculo
    {
        public string cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double velocidadeMaxima { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int qtdRodas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int qtdPortas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Acelerar()
        {
            throw new NotImplementedException();
        }

        public string Ligar()
        {
            throw new NotImplementedException();
        }

        public string Ligar(int velocidade)
        {
            throw new NotImplementedException();
        }

        public string Ligar(double vel)
        {
            throw new NotImplementedException();
        }
    }
}
