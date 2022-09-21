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

namespace Kadrovay_slujba
{
    public partial class RegistrForm : Form
    {

        string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=kadry;Integrated Security=True";


        public RegistrForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form lg = new loginForm();
            this.Hide();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form lg = new loginForm();
            this.Hide();
            lg.Show();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            addAdmin();
        }

        private void ClearAllFields()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void addAdmin()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string sqlExpression = "INSERT INTO Admins (lastName, firstName, patronymic, email, phone, login, password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "');";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                ClearAllFields();
                this.Hide();
                Form lgnForm = new loginForm();
                lgnForm.Show();
                MessageBox.Show("УСПЕШНАЯ РЕГИСТРАЦИЯ!", "Новый аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
