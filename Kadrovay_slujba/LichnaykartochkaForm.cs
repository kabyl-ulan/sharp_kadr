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
using WORK_TO_WORD;

namespace Kadrovay_slujba
{
    public partial class LichnaykartochkaForm : Form
    {   
        private string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=kadry; Integrated Security=True";

        private BindingSource bs = new BindingSource();

        private SqlConnection connect;

        public LichnaykartochkaForm()
        {
            InitializeComponent();
        }

        private void LichnaykartochkaForm_Load(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("select t1.tabelnyi_nomer, t2.surname, t2.name, t2.patronymic, t2.dateofbirdth, t2.education, t2.experience, t2.data_prinatia from sotrudnik t2 LEFT JOIN TrudDogovor t1 ON t2.id_sotrudnik = t1.id_sotrudnik; ");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty);
                textBox1.Text = Convert.ToString(id);

                DateTime dt = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty);
                textBox2.Text = Convert.ToString(dt);

                string surname = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                textBox3.Text = surname;

                string name = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                textBox4.Text = name;

                string patronymic = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                textBox5.Text = patronymic;

                DateTime dr = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty);
                textBox6.Text = Convert.ToString(dr);

                string education = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                textBox7.Text = education;

                string stj = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                textBox8.Text = stj;
            }

            else
            {
                MessageBox.Show("Ошибка!", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var helper = new Word_Helper("lichnay.docx");
           var items = new Dictionary<string, string>
           {
               { "@id", textBox1.Text },
               { "@data", textBox2.Text },
               { "@surname", textBox3.Text },
               { "@name", textBox4.Text },
               { "@patronymic", textBox5.Text },
               { "@dateofbirdth", textBox6.Text},
               { "@education", textBox7.Text },
               { "@experience", textBox8.Text },
           };

           helper.Process(items);
        }
    }
}
