using System;
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
            meuCarro.cor = "Vermelho";
            meuCarro.modelo = "Ferrari";
            meuCarro.qtdPortas = 2;
            meuCarro.qtdRodas = 4;
            meuCarro.velocidadeMaxima = 160;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Acelerar());
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Ligar());
        }
    }
}
