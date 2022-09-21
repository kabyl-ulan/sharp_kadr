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
    public partial class otdel : Form
    {
        public otdel()
        {
            InitializeComponent();
        }

        private void otdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kadrovay_slujbaDataSet);

        }

        private void otdel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadrovay_slujbaDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.kadrovay_slujbaDataSet.otdel);

        }
    }
}
