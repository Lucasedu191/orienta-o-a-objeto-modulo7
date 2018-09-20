﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo7OOB
{
    public partial class Form1 : Form
    {
        private Carro meuCarro;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            
            meuCarro = new Carro();
            meuCarro.cor = "Azul";
            meuCarro.qtdPortas = 2;
            MessageBox.Show ( ConverterParaString(meuCarro));
            //MessageBox.Show(meuCarro.cor);

            Motocicleta minhaMoto = new Motocicleta();
            minhaMoto.cor = "Vermelho";
            minhaMoto.Ligar();
            MessageBox.Show (ConverterParaString(minhaMoto));
            //MessageBox.Show(minhaMoto.Ligar());

        }

        public string ConverterParaString(IVeiculo veiculo)
        {
            if (typeof (IVeiculo) == veiculo.GetType())
            {
                return " Veiculo Cor: " + veiculo.cor;
            }
            else if(typeof(Carro) == veiculo.GetType())
            {
                return "Carro Cor: " + veiculo.cor;
            }
            else if (typeof(Motocicleta) == veiculo.GetType())
            {
                return "Moto Cor: " + veiculo.cor;
            }
            return String.Empty;
        }

    

    private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Acelerar());
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Ligar(10));
        }
    }
}
