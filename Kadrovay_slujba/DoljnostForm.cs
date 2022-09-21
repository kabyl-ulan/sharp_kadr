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
    public partial class DoljnostForm : Form
    {
        public DoljnostForm()
        {
            InitializeComponent();
        }

        private void DoljnostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadryDataSet1.doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.kadryDataSet1.doljnost);
        }

        private void doljnostBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadryDataSet1);
            this.doljnostTableAdapter.Update(this.kadryDataSet1.doljnost);

        }
    }
}
