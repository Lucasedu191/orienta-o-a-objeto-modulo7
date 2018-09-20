using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModulo7OOB
{
    
    
        public class Veiculo
        {

            public String cor { get; set; }
            public String modelo { get; set; }
            public double velocidadeMaxima { get; set; }
            public int qtdRodas { get; set; }
            public int qtdPortas { get; set; }


            public string Ligar()
            {
                return "Veiculo Ligado";
            }

            public string Ligar(int velocidade)
            {
                return "Veiculo Ligado";
            }

            public string Ligar(double vel)
            {
                return "Veiculo Ligado";
            }


            public string Acelerar()
            {
                return "Veiculo acelerou";
            }
    
        }
}
