using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeVetor
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double soma = 0, media;
            double[] vetornotas = new double[30];
            int i;

            for (i = 0; i < 30; i++)
            {
                vetornotas[i] = Convert.ToDouble(txtNota.Text);
            }

            media = soma / 30;

            txtMedia.Text = media.ToString();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            txtNota.Clear();
        }

        
            private void btnProximo_Click(object sender, EventArgs e)
        {
            
            
            }
        }

    }


