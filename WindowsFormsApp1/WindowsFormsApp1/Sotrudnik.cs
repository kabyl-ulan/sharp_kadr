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
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void sotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadrovay_slujbaDataSet);
        }

        private void Sotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrovay_slujbaDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.kadrovay_slujbaDataSet.Sotrudnik);
        }

        //Обновить данные
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sotrudnikTableAdapter.Fill(this.kadrovay_slujbaDataSet.Sotrudnik);
        }

        //Поиск по фамилии
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.Filter = "surname=\'" + toolStripTextBox1.Text + "\'";
        }
    }
}
