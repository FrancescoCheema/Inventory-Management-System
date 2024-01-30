using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Francesco_Cheema___Inventory
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();


            dataGridView1.DataSource = ListClass.MyList;

            dataGridView2.DataSource = partList;

            textBox1.TextChanged += TextBox_Changed;
            textBox3.TextChanged += TextBox_Changed;
            textBox4.TextChanged += TextBox_Changed;
            textBox5.TextChanged += TextBox_Changed;
            textBox6.TextChanged += TextBox_Changed;

            string s = textBox2.Text;

            if (string.IsNullOrEmpty(s))
            {
                textBox1.BackColor = System.Drawing.Color.IndianRed;
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                textBox5.BackColor = System.Drawing.Color.IndianRed;
                textBox6.BackColor = System.Drawing.Color.IndianRed;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox1.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsLetter))
            {
                textBox1.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox1, "Name Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox3.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsDigit))
            {
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox3, "Inventory Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox4.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsDigit))
            {
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox4, "Price Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox6.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsDigit))
            {
                textBox6.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox6, "Maximum Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        BindingList<PartClass> partList = new BindingList<PartClass>(ListParts.MyList);

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string cellValue = selectedRow.Cells[0].Value.ToString();

                try
                {
                    PartClass newPart = new PartClass(
                        Int32.Parse(selectedRow.Cells[0].Value.ToString()),
                        selectedRow.Cells[1].Value.ToString(),
                        Int32.Parse(selectedRow.Cells[2].Value.ToString()),
                        Int32.Parse(selectedRow.Cells[3].Value.ToString())
                    );

                    partList.Add(newPart);
                    dataGridView2.Refresh();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows.Count - 1);
                }
            
        }
            else
            {
                MessageBox.Show("No row is selected to delete.");
            }
        }

        private bool button3WasClicked = true;

        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            string maxText = textBox6.Text;
            string minText = textBox5.Text;
            int max = 0;
            int min = 0;

            if (ValidateNumericInput(maxText, out max) &&
                (ValidateNumericInput(minText, out min)))
            {
                if (min > max && button3WasClicked)
                {
                    MessageBox.Show("Your minimum exceeds your maximu.");
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
            }
        }

        private int SelectedRowIndex;

        private void button3_Click(object sender, EventArgs e)
        {
            string maxText = textBox6.Text;
            string minText = textBox5.Text;
            string ProductName = textBox1.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            int max = 0;
            int min = 0;
            int inventory = 0;
            int price = 0;


            if (ValidateNumericInput(maxText, out max) &&
                ValidateNumericInput(inventoryText, out inventory) &&
                    ValidateNumericInput(priceText, out price) &&
                (ValidateNumericInput(minText, out min)))
            {
                if (min > max && button3WasClicked)
                {
                    MessageBox.Show("Your minimum exceeds your maximum.");
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
            }
            if (dataGridView2.Rows.Count > 0)
            {
                button3.Enabled = true;

                int maxProductID = ProductsList.MyList.Max(p => p.ProductID);
                int nextPartID = maxProductID + 1;

                Products newProduct = new Products(nextPartID, ProductName, inventory, price, min, max);

                ProductsList.MyList.Add(newProduct);

                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                form1.dataGridView2.DataSource = null;
                form1.dataGridView2.DataSource = ProductsList.MyList;

                Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

                if (form2 != null)
                {
                    dataGridView2.Refresh();
                }


                MessageBox.Show("Changes Saved Successfully");
                this.Close();
            }

            else if (button3WasClicked && dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Must have at least one associated part.");
            }
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox5.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsDigit))
            {
                textBox5.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox5, "Minimum Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
