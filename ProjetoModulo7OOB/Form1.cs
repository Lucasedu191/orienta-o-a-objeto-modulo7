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
            MessageBox.Show(meuCarro.cor);

            Motocicleta minhaMoto = new Motocicleta();
            minhaMoto.cor = "Vermelho";
            minhaMoto.Ligar();
            MessageBox.Show(minhaMoto.cor);
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
