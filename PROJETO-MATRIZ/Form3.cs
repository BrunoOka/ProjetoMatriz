using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_MATRIZ
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        Double[] num = new double[10];
        int i = 0;
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                num[i] = Convert.ToDouble(txtnum.Text);
                if (num[i] < 0)
                {
                    MessageBox.Show("Número inválido! Digite um número positivo.");
                    txtnum.Clear();
                    txtnum.Focus();
                    return;
                }
                txta.Text += Convert.ToString(num[i]) + Environment.NewLine;
                i++;
                txtnum.Clear();
                txtnum.Focus();
            }
            else
            {
                MessageBox.Show("Matriz cheia!");
                btnadicionar.Hide();
                btncalcular.Show();
                i = 0;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double [] negativo = new double[10];
            while (i < 10)
            {
                negativo[i] = num[i] * -1;
                txtb.Text += negativo[i] + Environment.NewLine;
                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
