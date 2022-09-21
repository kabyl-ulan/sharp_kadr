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
    public partial class Doljnost : Form
    {
        public Doljnost()
        {
            InitializeComponent();
        }

        private void doljnostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadrovay_slujbaDataSet);

        }

        private void Doljnost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrovay_slujbaDataSet.doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.kadrovay_slujbaDataSet.doljnost);

        }
    }
}
