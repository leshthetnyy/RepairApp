using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairApp
{
    public partial class Client : Form
    {
        private string LoginAuthorizationC;
        private string PasswordAuthorizationC;
        public Client(string LoginAuthorization, string PasswordAuthorization)
        {
            InitializeComponent();
            this.LoginAuthorizationC = LoginAuthorization;
            this.PasswordAuthorizationC = PasswordAuthorization;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatingNewRequest creatingNewRequest = new CreatingNewRequest(LoginAuthorizationC, PasswordAuthorizationC);
            creatingNewRequest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }
    }
}
