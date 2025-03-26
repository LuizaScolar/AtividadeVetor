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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {

        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int[] num = new int[15];
            Random random = new Random();
            txtSortear.Text = "";  // Limpa antes de adicionar novos valores

            for (int i = 0; i < 15; i++)
            {
                num[i] = random.Next(1, 100); // Gera números aleatórios de 1 a 99

                // Se a posição for par, adiciona ao txtSortear
                if (i % 2 == 0)
                {
                    txtSortear.Text += num[i].ToString() + " ";  // Concatena corretamente
                }
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSortear.Clear();
        }
    }
}
