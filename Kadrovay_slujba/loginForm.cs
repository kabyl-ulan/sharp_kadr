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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form rg = new RegistrForm();
            this.Hide();
            rg.Show();
        }

        private void ClearAllFields()
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader dr;

                string usr = textBox1.Text;
                string psw = textBox2.Text;
                con = new SqlConnection(@"Data Source=DESKTOP-V19EI0C;Initial Catalog=kadry;Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                string str = "SELECT * FROM Admins where login='" + usr + "' AND password='" + psw + "'";
                cmd.CommandText = str;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ClearAllFields();
                    Form mnFrm = new MainForm();
                    this.Hide();
                    mnFrm.Show();
                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAllFields();
                }

                con.Close();
            }
        }
    }
}
