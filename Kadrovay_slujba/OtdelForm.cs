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
    public partial class OtdelForm : Form
    {
        public OtdelForm()
        {
            InitializeComponent();
        }

        private void OtdelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadryDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter1.Fill(this.kadryDataSet.otdel);
        }

        private void otdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.kadryDataSet);
            this.otdelTableAdapter1.Update(this.kadryDataSet.otdel);

        }
    }
}
