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
        int[] vetornotas = new int[30];
        int i, soma = 0, nota, media;
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
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
            soma = 0;
            txtMedia.Clear();
            txtNota.Clear();
        }

        
            private void btnProximo_Click(object sender, EventArgs e)
        {
            
            
            }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                nota = Convert.ToInt32(txtNota.Text);
                vetornotas[i] = nota;
                soma = soma + vetornotas[i];
                txtNota.Clear();
                txtNota.Focus();
                break;
            }
        }
    }

    }


