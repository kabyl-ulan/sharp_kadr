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
    public partial class ZarplataForm : Form
    {
        public ZarplataForm()
        {
            InitializeComponent();
        }

        private void ZarplataForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadryDataSet1.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.kadryDataSet1.zarplata);
        }

        private void zarplataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.zarplataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadryDataSet1);
            this.zarplataTableAdapter.Update(this.kadryDataSet1.zarplata);

        }
    }
}
