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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi1_Click(object sender, EventArgs e)
        {
            Hide();
            frm1 a = new frm1();
            a.Show();
        }

        private void tsmi2_Click(object sender, EventArgs e)
        {
            Hide();
            frm3 b = new frm3();
            b.Show();
        }

        private void tsmi3_Click(object sender, EventArgs e)
        {
            Hide();
            frm4 c = new frm4();
            c.Show();
        }
    }
}
