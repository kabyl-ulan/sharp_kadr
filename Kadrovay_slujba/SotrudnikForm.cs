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
    public partial class SotrudnikForm : Form
    {
        public SotrudnikForm()
        {
            InitializeComponent();
        }

        private void SotrudnikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadryDataSet1.sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.kadryDataSet1.sotrudnik);

        }

        private void sotrudnikBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadryDataSet1);
            this.sotrudnikTableAdapter.Update(this.kadryDataSet1.sotrudnik);

        }
    }
}
