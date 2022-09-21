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
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using WORK_TO_WORD;

namespace Kadrovay_slujba
{
    public partial class OSotrudForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=kadry;Integrated Security=True";

        private BindingSource bs = new BindingSource();

        private SqlConnection connect;

        public OSotrudForm()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mnFrm = new MainForm();
            this.Hide();
            mnFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT id_sotrudnik, surname, name, patronymic, education, experience FROM sotrudnik WHERE data_uvalnenia is null and education LIKE 'Выс%';");
            ViewQuery();
            CloseConnect();
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT id_sotrudnik, surname, name, patronymic, education, experience, data_prinatia, data_uvalnenia FROM sotrudnik WHERE data_uvalnenia is not null;");
            ViewQuery();
            CloseConnect();
        }

        private void OSotrudForm_Load(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT * FROM sotrudnik;");
            ViewQuery();
            CloseConnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT id_sotrudnik, surname, name, patronymic, education, experience FROM sotrudnik WHERE experience>2 AND data_uvalnenia IS NULL;");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sotrFrm = new SotrudnikForm();
            sotrFrm.Owner = this;
            sotrFrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("select *from sotrudnik where surname like '"+txtSearch.Text+ "%' or name like '" + txtSearch.Text + "%' or patronymic like '" + txtSearch.Text + "%';");
            ViewQuery();
            CloseConnect();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            OpenConnect();
            ExecSql("SELECT * FROM sotrudnik;");
            ViewQuery();
            CloseConnect();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT * FROM sotrudnik;");
            ViewQuery();
            CloseConnect();

            var helper = new Word_Helper("lichnay.docx");
            var items = new Dictionary<string, string>
            {
                { "@id", dataGridView1.Rows[0].Cells[0].Value.ToString() },
                { "@data", dataGridView1.Rows[0].Cells[0].Value.ToString()  },
                { "@surname", dataGridView1.Rows[0].Cells[0].Value.ToString()  },
                { "@name", dataGridView1.Rows[0].Cells[0].Value.ToString() },
                { "@patronymic", dataGridView1.Rows[0].Cells[0].Value.ToString() },
                { "@dateofbirdth", dataGridView1.Rows[0].Cells[0].Value.ToString() },
                { "@education", dataGridView1.Rows[0].Cells[0].Value.ToString() },
                { "@experience", dataGridView1.Rows[0].Cells[0].Value.ToString() },
            };

            string jobid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;

            helper.Process(items);
        }
    }
}
