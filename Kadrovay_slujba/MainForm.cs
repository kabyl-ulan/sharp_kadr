using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadrovay_slujba
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSotrudnik_Click(object sender, EventArgs e)
        {
            Form oSotFrm = new OSotrudForm();
            this.Hide();
            oSotFrm.Show();
        }

        private void отделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtdelForm otdelFrm = new OtdelForm();
            otdelFrm.Owner = this;
            otdelFrm.Show();
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoljnostForm doljFrm = new DoljnostForm();
            doljFrm.Owner = this;
            doljFrm.Show();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SotrudnikForm sotrudFrm = new SotrudnikForm();
            sotrudFrm.Owner = this;
            sotrudFrm.Show();
        }

        private void зарплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZarplataForm zarplatFrm = new ZarplataForm();
            zarplatFrm.Owner = this;
            zarplatFrm.Show();
        }

        private void btnZarplata_Click(object sender, EventArgs e)
        {
            OZarplataForm zrFrm = new OZarplataForm();
            zrFrm.Owner = this;
            zrFrm.Show();
        }

        private void btnDoljnost_Click(object sender, EventArgs e)
        {
            ODoljnostForm frm = new ODoljnostForm();
            frm.Owner = this;
            frm.Show();
        }

        private void btnOtdel_Click(object sender, EventArgs e)
        {
            LichnaykartochkaForm frm = new LichnaykartochkaForm();
            frm.Owner = this;
            frm.Show();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
