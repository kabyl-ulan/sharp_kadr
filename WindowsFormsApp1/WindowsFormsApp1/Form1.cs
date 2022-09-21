using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void отделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOtdel = new otdel();
            frmOtdel.Owner = this;
            frmOtdel.Show();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSotrudnik = new Sotrudnik();
            frmSotrudnik.Owner = this;
            frmSotrudnik.Show();
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDoljnost = new Doljnost();
            frmDoljnost.Owner = this;
            frmDoljnost.Show();
        }
    }
}
