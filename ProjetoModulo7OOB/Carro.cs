using System;

namespace ProjetoModulo7OOB
{
    public class Carro
    {
        public Carro(String cor, String modelo, double velocidadeMaxima, int qtdRodas, int qtdPortas)
        {
            setCor(cor);
            setModelo(modelo);
            setVelocidadeMaxima(velocidadeMaxima);
            setQtdRodas(qtdRodas);
            setQtdPortas(qtdPortas);

        }

        private String cor;
        private String modelo;
        private double velocidadeMaxima;
        private int qtdRodas;
        private int qtdPortas;

        //cor
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }

        //modelo
        public void setModelo(string Modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }

        //velocidadeMaxima
        public void setVelocidadeMaxima(double velocidadeMaxima)
        {
            this.velocidadeMaxima = velocidadeMaxima;
        }
        public double getVelocidadeMaxima()
        {
            return this.velocidadeMaxima;
        }

        //quantidade rodas
        public void setQtdRodas(int qtdRodas)
        {
            this.qtdRodas = qtdRodas;
        }
        public double getqtdRodas()
        {
            return this.qtdRodas;
        }
        //quantidade de portas
        public void setQtdPortas(int qtdPortas)
        {
            this.qtdPortas = qtdPortas;
        }
        public double getqtdPortas()
        {
            return this.qtdPortas;
        }
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
