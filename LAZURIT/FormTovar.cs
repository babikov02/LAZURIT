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
    public partial class FormTovar : Form
    {
        public FormTovar()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowTovar();
        }

        void ShowTovar()
        {
            listViewDivan.Items.Clear();
            listViewKreslo.Items.Clear();
            listViewKrovat.Items.Clear();

            foreach (TovarSet tovar in Program.lazur.TovarSet)
            {
                if (tovar.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        tovar.Name, tovar.Material, tovar.Lenght.ToString(),
                        tovar.Width.ToString(), tovar.Height.ToString()
                    });

                    item.Tag = tovar;

                    listViewDivan.Items.Add(item);
                }
                else if (tovar.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        tovar.Name, tovar.Material, tovar.Lenght.ToString(),
                        tovar.Width.ToString(), tovar.Height.ToString()
                    });

                    item.Tag = tovar;

                    listViewKreslo.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        tovar.Name, tovar.Material, tovar.Lenght.ToString(),
                        tovar.Width.ToString(), tovar.Height.ToString()
                    });

                    item.Tag = tovar;

                    listViewKrovat.Items.Add(item);
                }
            }
            listViewDivan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewKreslo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewKrovat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormTovar_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewDivan.Visible = true;

                listViewKreslo.Visible = false;
                listViewKrovat.Visible = false;

                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewKreslo.Visible = true;

                listViewDivan.Visible = false;
                listViewKrovat.Visible = false;

                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewKrovat.Visible = true;

                listViewDivan.Visible = false;
                listViewKreslo.Visible = false;

                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
        }

        private void listViewDivan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDivan.SelectedItems.Count == 1)
            {
                TovarSet tovar = listViewDivan.SelectedItems[0].Tag as TovarSet;
                textBoxName.Text = tovar.Name;
                textBoxMaterial.Text = tovar.Material;
                textBoxLenght.Text = tovar.Lenght.ToString();
                textBoxWidth.Text = tovar.Width.ToString();
                textBoxHeight.Text = tovar.Height.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
        }

        private void listViewKreslo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKreslo.SelectedItems.Count == 1)
            {
                TovarSet tovar = listViewKreslo.SelectedItems[0].Tag as TovarSet;
                textBoxName.Text = tovar.Name;
                textBoxMaterial.Text = tovar.Material;
                textBoxLenght.Text = tovar.Lenght.ToString();
                textBoxWidth.Text = tovar.Width.ToString();
                textBoxHeight.Text = tovar.Height.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
        }

        private void listViewKrovat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKrovat.SelectedItems.Count == 1)
            {
                TovarSet tovar = listViewKrovat.SelectedItems[0].Tag as TovarSet;
                textBoxName.Text = tovar.Name;
                textBoxMaterial.Text = tovar.Material;
                textBoxLenght.Text = tovar.Lenght.ToString();
                textBoxWidth.Text = tovar.Width.ToString();
                textBoxHeight.Text = tovar.Height.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxMaterial.Text = "";
                textBoxLenght.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TovarSet tovar = new TovarSet();

            tovar.Name = textBoxName.Text;
            tovar.Material = textBoxMaterial.Text;
            tovar.Lenght = Convert.ToDouble(textBoxLenght.Text);
            tovar.Width = Convert.ToDouble(textBoxWidth.Text);
            tovar.Height = Convert.ToDouble(textBoxHeight.Text);
            

            if (comboBoxType.SelectedIndex == 0)
            {
                tovar.Type = 0;
                
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                tovar.Type = 1; 
            }
            else
            {
                tovar.Type = 2;
            }
            Program.lazur.TovarSet.Add(tovar);

            Program.lazur.SaveChanges();
            ShowTovar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewDivan.SelectedItems.Count == 1)
                {
                    TovarSet tovar = listViewDivan.SelectedItems[0].Tag as TovarSet;

                    tovar.Name = textBoxName.Text;
                    tovar.Material = textBoxMaterial.Text;
                    tovar.Lenght = Convert.ToDouble(textBoxLenght.Text);
                    tovar.Width = Convert.ToDouble(textBoxWidth.Text);
                    tovar.Height = Convert.ToDouble(textBoxHeight.Text);

                    Program.lazur.SaveChanges();

                    ShowTovar();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewKreslo.SelectedItems.Count == 1)
                {
                    TovarSet tovar = listViewKreslo.SelectedItems[0].Tag as TovarSet;

                    tovar.Name = textBoxName.Text;
                    tovar.Material = textBoxMaterial.Text;
                    tovar.Lenght = Convert.ToDouble(textBoxLenght.Text);
                    tovar.Width = Convert.ToDouble(textBoxWidth.Text);
                    tovar.Height = Convert.ToDouble(textBoxHeight.Text);

                    Program.lazur.SaveChanges();

                    ShowTovar();
                }
            }
            else
            {
                if (listViewKrovat.SelectedItems.Count == 1)
                {
                    TovarSet tovar = listViewKrovat.SelectedItems[0].Tag as TovarSet;

                    tovar.Name = textBoxName.Text;
                    tovar.Material = textBoxMaterial.Text;
                    tovar.Lenght = Convert.ToDouble(textBoxLenght.Text);
                    tovar.Width = Convert.ToDouble(textBoxWidth.Text);
                    tovar.Height = Convert.ToDouble(textBoxHeight.Text);

                    Program.lazur.SaveChanges();

                    ShowTovar();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewDivan.SelectedItems.Count == 1)
                    {
                        TovarSet tovar = listViewDivan.SelectedItems[0].Tag as TovarSet;
                        Program.lazur.TovarSet.Remove(tovar);
                        Program.lazur.SaveChanges();
                        ShowTovar();
                    }

                    textBoxName.Text = "";
                    textBoxMaterial.Text = "";
                    textBoxLenght.Text = "";
                    textBoxWidth.Text = "";
                    textBoxHeight.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewKreslo.SelectedItems.Count == 1)
                    {
                        TovarSet tovar = listViewKreslo.SelectedItems[0].Tag as TovarSet;
                        Program.lazur.TovarSet.Remove(tovar);
                        Program.lazur.SaveChanges();
                        ShowTovar();
                    }

                    textBoxName.Text = "";
                    textBoxMaterial.Text = "";
                    textBoxLenght.Text = "";
                    textBoxWidth.Text = "";
                    textBoxHeight.Text = "";
                }
                else
                {
                    if (listViewKrovat.SelectedItems.Count == 1)
                    {
                        TovarSet tovar = listViewKrovat.SelectedItems[0].Tag as TovarSet;
                        Program.lazur.TovarSet.Remove(tovar);
                        Program.lazur.SaveChanges();
                        ShowTovar();
                    }

                    textBoxName.Text = "";
                    textBoxMaterial.Text = "";
                    textBoxLenght.Text = "";
                    textBoxWidth.Text = "";
                    textBoxHeight.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}

