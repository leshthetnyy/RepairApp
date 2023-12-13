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

namespace RepairApp
{
    public partial class Authorization : Form
    {
        private string LoginAuthorization;
        private string PasswordAuthorization;
        string SqlUrl = DataBaseConnection.ConnectionStringSql;
        string UserStatus;
        public Authorization()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                LoginAuthorization = textBox1.Text;
                PasswordAuthorization = textBox2.Text;
                UserAuthorization(LoginAuthorization, PasswordAuthorization);
            }
            else
                MessageBox.Show("Введите логин и пароль!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        public void UserAuthorization(string LoginAuthorization,string PasswordAuthorization)
        {
            SqlConnection str = new SqlConnection(SqlUrl);
            str.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Исполнители.Логин, Исполнители.Пароль, Исполнители.ID_Должности  FROM Исполнители  WHERE Логин = @Логин AND Пароль = @Пароль", str);
            command.Parameters.AddWithValue("Логин", textBox1.Text);
            command.Parameters.AddWithValue("Пароль", textBox2.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserStatus = reader[2].ToString();
            }
            reader.Close();

            if (table.Rows.Count > 0)
            {
                if (UserStatus == "1" || UserStatus == "2")
                {
                    Executor executor = new Executor(LoginAuthorization, PasswordAuthorization);
                    executor.Show();
                    this.Hide();
                    str.Close();
                }
            }
            else
            {
                str.Close();
                SqlConnection str1 = new SqlConnection(SqlUrl);
                str1.Open();
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand command1 = new SqlCommand("SELECT Клиенты.Логин, Клиенты.Пароль FROM Клиенты WHERE Логин = @Логин AND Пароль = @Пароль", str1);
                command1.Parameters.AddWithValue("Логин", textBox1.Text);
                command1.Parameters.AddWithValue("Пароль", textBox2.Text);
                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    UserStatus = reader1[1].ToString();
                }
                reader1.Close();

                if (table1.Rows.Count > 0)
                {
                        Client client = new Client(LoginAuthorization, PasswordAuthorization);
                        client.Show();
                        this.Hide();
                        str1.Close();
                }          
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                    str1.Close();
                }           
            }
        }
    }
}
