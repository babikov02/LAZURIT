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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.lazur.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.Id.ToString(), clientSet.FirstName, clientSet.LastName,
                    clientSet.MiddleName, clientSet.Phone, clientSet.Email
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);

            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            Program.lazur.ClientSet.Add(clientSet);
            Program.lazur.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                Program.lazur.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.lazur.ClientSet.Remove(clientSet);
                    Program.lazur.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
