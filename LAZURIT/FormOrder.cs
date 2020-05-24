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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ShowAgent();
            ShowClient();
            ShowTovar();
            ShowOrder();
        }

        void Price()
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxTovar.SelectedItem != null)
            {
                AgentSet agent
                    = Program.lazur.AgentSet.Find(Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]));
                ClientSet client
                    = Program.lazur.ClientSet.Find(Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]));
                TovarSet tovar
                    = Program.lazur.TovarSet.Find(Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]));
                double percentShop = tovar.Price * 0.05;
                textBoxPercentShop.Text = percentShop.ToString("0.00");
                if (agent.PersentSales != null)
                {
                    double percentAgent = tovar.Price * Convert.ToDouble(agent.PersentSales) / 100.00;
                    textBoxPercentAgent.Text = percentAgent.ToString("0.00");
                    
                    
                }
                else
                {
                    double percentAgent = tovar.Price * 0.03;
                    textBoxPercentAgent.Text = percentAgent.ToString("0.00");
                    
                }
                
            }
            else
            {
                textBoxPercentAgent.Text = "";
                textBoxPercentShop.Text = "";
                
                
            }
                
                
                
        }

        void ShowOrder()
        {
            
            listViewOrder.Items.Clear();
            
            foreach (OrderSet order in Program.lazur.OrderSet)
            {
                
                ListViewItem item = new ListViewItem(new string[]
                {
                   
                    order.ClientSet.LastName + " " + order.ClientSet.FirstName,
                    order.AgentSet.LastName + " " + order.AgentSet.FirstName,
                    order.TovarSet.Name, order.TovarSet.Price.ToString()
                    
                });
                item.Tag = order;
                listViewOrder.Items.Add(item);
            }
        }

        void ShowAgent()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentSet agent in Program.lazur.AgentSet)
            {
                string[] item = {agent.Id.ToString() + ".", agent.FirstName, agent.MiddleName,
                agent.LastName};
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet client in Program.lazur.ClientSet)
            {
                string[] item = {client.Id.ToString() + ".", client.FirstName, client.MiddleName,
                client.LastName};
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowTovar()
        {
            comboBoxTovar.Items.Clear();
            foreach (TovarSet tovar in Program.lazur.TovarSet)
            {
                if (tovar.Type == 0)
                {
                    string[] item = { tovar.Id.ToString() + ".", "Диван " + tovar.Name };
                    comboBoxTovar.Items.Add(string.Join(" ", item));
                }
                else if (tovar.Type == 1)
                {
                    string[] item = { tovar.Id.ToString() + ".", "Кресло " + tovar.Name };
                    comboBoxTovar.Items.Add(string.Join(" ", item));
                }
                else if (tovar.Type == 2)
                {
                    string[] item = { tovar.Id.ToString() + ".", "Кровать " + tovar.Name };
                    comboBoxTovar.Items.Add(string.Join(" ", item));
                }
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price();
        }

        private void comboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price();
        }

        private void comboBoxTovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxTovar.SelectedItem != null)
            {
                OrderSet order = new OrderSet();
                order.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                order.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                order.IdTovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);
                
                Program.lazur.OrderSet.Add(order);
                Program.lazur.SaveChanges();
                ShowOrder();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                OrderSet order = listViewOrder.SelectedItems[0].Tag as OrderSet;

                order.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                order.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                order.IdTovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);

                Program.lazur.SaveChanges();
                ShowOrder();
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                OrderSet order = listViewOrder.SelectedItems[0].Tag as OrderSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(order.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(order.IdClient.ToString());
                comboBoxTovar.SelectedIndex = comboBoxTovar.FindString(order.IdTovar.ToString());
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxTovar.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    OrderSet order = listViewOrder.SelectedItems[0].Tag as OrderSet;
                    Program.lazur.OrderSet.Remove(order);
                    Program.lazur.SaveChanges();
                    ShowOrder();
                }
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxTovar.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
