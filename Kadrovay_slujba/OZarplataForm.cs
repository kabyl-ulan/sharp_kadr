using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kadrovay_slujba
{
    public partial class OZarplataForm : Form
    {

        private string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=kadry;Integrated Security=True";

        private BindingSource bs = new BindingSource();

        private SqlConnection connect;

        public OZarplataForm()
        {
            InitializeComponent();
        }

        private void OpenConnect()
        {
            connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
            }

            catch
            {
                string mes = "Ошибка!";
                string error = "Невозможно подключиться к БД!";
                MessageBox.Show(mes, error, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExecSql(string sqltext)
        {
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = sqltext;
            cmd.ExecuteNonQuery();
            DataTable tab = new DataTable();
            tab.Load(cmd.ExecuteReader());
            bs.DataSource = tab.DefaultView;
        }

        public void ViewQuery()
        {
            dataGridView1.DataSource = bs;
        }

        private void CloseConnect()
        {
            connect.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT surname, name, patronymic, 'получает на должности', nazvanie, oklad,'+', razmer_premii,'=', oklad+razmer_premii, 'сом' FROM doljnost join sotrudnik ON doljnost.id_doljnost = sotrudnik.id_doljnost join zarplata ON sotrudnik.id_sotrudnik = zarplata.id_sotrudnik; ");
            ViewQuery();
            CloseConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveTable(dataGridView1);
        }

        private void SaveTable(DataGridView dgv)
        {

            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dgv.RowCount - 2; i++)
            {
                for (j = 0; j <= dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dgv[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }
    }
}
