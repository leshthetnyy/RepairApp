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
    public partial class Executor : Form
    {

        string NumberApp, DateAdded, Equipment, TypeOfEquipment, Description, Status, ClientName;
        private string LoginAuthorizationE;
        private string PasswordAuthorizationE;
        string SqlUrl = DataBaseConnection.ConnectionStringSql;
        public Executor(string LoginAuthorization, string PasswordAuthorization)
        {
            InitializeComponent();
            this.LoginAuthorizationE = LoginAuthorization;
            this.PasswordAuthorizationE = PasswordAuthorization;
            OutputOfNewApplications();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            textBox2.Enabled = false;
        }

        private void Executor_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        public void OutputOfNewApplications()
        {
            SqlConnection str = new SqlConnection(SqlUrl);
            str.Open();
            String command = "SELECT ID_Заявки as 'Номер', FORMAT(Дата_добавления, 'dd/MM/yyyy') as 'Дата добавления', Оборудование as 'Оборудование', Название_типа_неисправности as 'Тип неисправности' FROM Заявки JOIN Типы_неисправностей ON Типы_неисправностей.ID_Типа_неисправности = Заявки.ID_Типа_неисправности JOIN Клиенты ON Клиенты.ID_Клиента = Заявки.ID_Клиента WHERE Заявки.ID_Статуса_заявки = 1";
            SqlDataAdapter a = new SqlDataAdapter(command, str);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;

            if (ds.Tables[0].Rows.Count > 0)
            {
                // код, если новые заявки есть
                //button7.Enabled = true;
                //button8.Enabled = true;
                //dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                // код, если новых заявок нет
                //button7.Enabled = false;
                //button8.Enabled = false;
            }
            str.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Application_ID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Application_ID;
            panel1.Visible = true;
            textBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatingNewRequest creatingNewRequest = new CreatingNewRequest(LoginAuthorizationE, PasswordAuthorizationE);
            creatingNewRequest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void Executor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_РЕМОНТDataSet.Статусы_заявок". При необходимости она может быть перемещена или удалена.
            this.статусы_заявокTableAdapter.Fill(this.бД_РЕМОНТDataSet.Статусы_заявок);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OutputOfNewApplications();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Application_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            OpenApplication(Application_ID);
            panel1.Visible = false;
            textBox1.Visible = true;
        }

        public void OpenApplication(int ID)
        {
            SqlConnection str = new SqlConnection(SqlUrl);
            str.Open();
            SqlCommand command = new SqlCommand("SELECT ID_Заявки as 'Номер', FORMAT(Дата_добавления, 'dd/MM/yyyy') as 'Дата добавления', Оборудование as 'Оборудование', Название_типа_неисправности as 'Тип неисправности', Описание_проблемы as 'Описание', Название_статуса_заявки as 'Статус', ФИО_Клиента as 'Клиент' FROM Заявки JOIN Типы_неисправностей ON Типы_неисправностей.ID_Типа_неисправности = Заявки.ID_Типа_неисправности JOIN Статусы_заявок ON Статусы_заявок.ID_Статуса_заявки = Заявки.ID_Статуса_заявки JOIN Клиенты ON Клиенты.ID_Клиента = Заявки.ID_Клиента WHERE ID_Заявки = @id", str);
            command.Parameters.AddWithValue("id", ID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NumberApp = reader[0].ToString();
                DateAdded = reader[1].ToString();
                Equipment = reader[2].ToString();
                TypeOfEquipment = reader[3].ToString();
                Description = reader[4].ToString();
                Status = reader[5].ToString();
                ClientName = reader[6].ToString();


                textBox1.Text = "Номер заявки: " + NumberApp +
                    Environment.NewLine + "Дата добавления: " + DateAdded +
                       Environment.NewLine + "Оборудование: " + Equipment +
                         Environment.NewLine + "Тип неисправности: " + TypeOfEquipment +
                           Environment.NewLine + "Описание: " + Description +
                                  Environment.NewLine + "Статус: " + Status +
                                         Environment.NewLine + "Клиент: " + ClientName;

            }
            reader.Close();
            str.Close();
        }
    }
}
