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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.lazur.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        agentSet.Id.ToString(), agentSet.FirstName, agentSet.LastName, agentSet.MiddleName,agentSet.Phone,
                    agentSet.Salary.ToString(), agentSet.PersentSales.ToString()
                });

                item.Tag = agentSet;

                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void labelSalary_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void FormAgent_Load(object sender, EventArgs e)
        {

        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxPhone.Text = agentSet.Phone;
                textBoxSalary.Text = agentSet.Salary.ToString();
                textBoxPercentSales.Text = agentSet.PersentSales.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxSalary.Text = "";
                textBoxPercentSales.Text = "";
                
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentSet agentSet = new AgentSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.Phone = textBoxPhone.Text;
            agentSet.Salary = Convert.ToInt32(textBoxSalary.Text);
            agentSet.PersentSales = Convert.ToDouble(textBoxPercentSales.Text);
            Program.lazur.AgentSet.Add(agentSet);
            Program.lazur.SaveChanges();
            ShowAgent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.Phone = textBoxPhone.Text;
                agentSet.Salary = Convert.ToInt32(textBoxSalary.Text);
                agentSet.PersentSales = Convert.ToDouble(textBoxPercentSales.Text);
                Program.lazur.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    Program.lazur.AgentSet.Remove(agentSet);
                    Program.lazur.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxSalary.Text = "";
                textBoxPercentSales.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPercentSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
