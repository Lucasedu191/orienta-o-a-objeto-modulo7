using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModulo7OOB
{


    public abstract class Veiculo
    {

        public String cor { get; set; }
        public String modelo { get; set; }
        public double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }


        public abstract string Ligar();

        public abstract string Ligar(int velocidade);

        public abstract string Ligar(double vel);

        public abstract string Acelerar();
        
    }
}
