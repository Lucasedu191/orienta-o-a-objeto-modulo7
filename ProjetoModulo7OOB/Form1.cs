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
            meuCarro.setCor ("Vermelho");
            meuCarro.setModelo ("Ferrari");
            meuCarro.setQtdPortas (2);
            meuCarro.setQtdRodas (4);
            meuCarro.setVelocidadeMaxima (160);
            
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
