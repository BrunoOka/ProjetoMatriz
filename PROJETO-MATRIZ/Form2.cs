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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();

        }
        Double[] num = new double[15];
        int i = 0;
        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (i < 15)
            {
                num[i] = Convert.ToDouble(txtnum.Text);
                txta.Text += Convert.ToString(num[i]) + Environment.NewLine;
                i++;
                txtnum.Clear();
                txtnum.Focus();

            }
            else
            {
                MessageBox.Show("Matriz cheia!");
                btnadd.Hide();
                btncalc.Show();
                i = 0;
            }
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double[] quadrado = new double[15];
            while (i < 15) {
                quadrado[i] = num[i] * num[i];
                txtb.Text += quadrado[i] + Environment.NewLine;
                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtnum.Clear();
            txtnum.Focus();
            btncalc.Hide();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}

