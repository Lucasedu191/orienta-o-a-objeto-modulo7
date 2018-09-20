using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModulo7OOB
{
    public class Motocicleta : IVeiculo
    {
        public override string Acelerar()
        {
            throw new NotImplementedException();
        }

        public string Ligar()
        {
            return "Moto Ligada";
        }
    }
}
