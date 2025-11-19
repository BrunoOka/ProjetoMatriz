using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_MATRIZ
{
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        Double[] num = new double[30];
        Double[] cubo = new double[30];
        int i = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (i < 30)
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
                btnpesquisar.Show();
                btncalcular.Show();
                i = 0;
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtpesquisa.Text);
            bool encontrou = false;

            for (int i = 0; i < 30; i++) { }
            if (c)
            {
                encontrou = false;
            }
        }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            while (i < 30)
            {
                cubo[i] = Math.Pow(num[i], 3);
                txtb.Text += cubo[i] + Environment.NewLine;
                i++;
            }
        }
    }
}
