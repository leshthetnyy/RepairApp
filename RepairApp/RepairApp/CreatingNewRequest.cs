using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairApp
{
    public partial class CreatingNewRequest : Form
    {
        private string LoginAuthorizationN;
        private string PasswordAuthorizationN;

        string SqlUrl = DataBaseConnection.ConnectionStringSql;
        string UserStatus;
        public CreatingNewRequest(string LoginAuthorization, string PasswordAuthorization)
        {
            InitializeComponent();
            this.LoginAuthorizationN = LoginAuthorization;
            this.PasswordAuthorizationN = PasswordAuthorization;
        }

        private void CreatingNewRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserAuthorization(LoginAuthorizationN, PasswordAuthorizationN);
        }

        public void UserAuthorization(string LoginAuthorization, string PasswordAuthorization)
        {
            SqlConnection str = new SqlConnection(SqlUrl);
            str.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Исполнители.Логин, Исполнители.Пароль, Исполнители.ID_Должности  FROM Исполнители  WHERE Логин = @Логин AND Пароль = @Пароль", str);
            command.Parameters.AddWithValue("Логин", LoginAuthorizationN);
            command.Parameters.AddWithValue("Пароль", PasswordAuthorizationN);
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
                command1.Parameters.AddWithValue("Логин", LoginAuthorizationN);
                command1.Parameters.AddWithValue("Пароль", PasswordAuthorizationN);
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
            }
        }
    }
}
