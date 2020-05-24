using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAZURIT
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAutorization.users.type == "agent") buttonAgent.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAutorization.users.login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonAgent_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonTovar_Click(object sender, EventArgs e)
        {
            Form formTovar = new FormTovar();
            formTovar.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrder();
            formOrder.Show();
        }

        private void labelLazur_Click(object sender, EventArgs e)
        {

        }
    }
}
