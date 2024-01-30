using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            dataGridView1.DataSource = ListClass.MyList;
            dataGridView2.DataSource = partList;
        }

        public void SetTextBoxValues(string value1, string value2, decimal value3, int value4, int value5, int value6)
        {
            textBox1.Text = value1;
            textBox2.Text = value2;
            textBox3.Text = value3.ToString();
            textBox4.Text = value4.ToString();
            textBox5.Text = value5.ToString();
            textBox6.Text = value6.ToString();
        }


        public string ModifiedName { get; private set; }
        public int ModifiedInStock{ get; private set; }
        public decimal ModifiedPrice { get; private set; }
        public int ModifiedMax { get; private set; }
        public int ModifiedMin { get; private set; }


        private bool button3WasClicked = true;


        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new ToolTip();

            string s = textBox3.Text;

            if (string.IsNullOrEmpty(s) || s.All(char.IsLetter))
            {
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.ForeColor = System.Drawing.Color.Gray;
                tooltip1.SetToolTip(textBox3, "Inventory is Required");
                button3.Enabled = false;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void SetDataSource(DataGridView dataGridView1)
        {
            throw new NotImplementedException();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowIndex = e.RowIndex;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 218, 185);
            bool found = false;
            string searchText = textBox7.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                for (int i = 0; i < ListClass.MyList.Count; i++)
                {
                    string partName = ListClass.MyList[i].Name.Trim();
                    if (partName.ToUpper().Contains(searchText.ToUpper()))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox3.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsDigit))
            {
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox3, "Name is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox4.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter) || (!int.TryParse(s, out int intResult) && !decimal.TryParse(s, out decimal decimalResult)))
            {
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox4, "Name is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox6.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox6.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox6, "Name is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox5.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox5.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox5, "Name is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button3.Enabled = false;
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White;
                button3.Enabled = true;
            }
        }
        private int SelectedRowIndex;

        private bool ValidateNumericInput(string text, out decimal result)
        {
            if (decimal.TryParse(text, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateNumericInputInt(string text, out int result)
        {
            if (int.TryParse(text, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox5Text = textBox5.Text;
            decimal price = 0;
            int inventory = 0;
            int max = 0;
            int min = 0;

            bool allFieldsEntered = !string.IsNullOrEmpty(inventoryText) &&
                                    !string.IsNullOrEmpty(priceText) &&
                                    !string.IsNullOrEmpty(textBox6Text) &&
                                    !string.IsNullOrEmpty(textBox5Text);

            if (allFieldsEntered &&
                ValidateNumericInput(inventoryText, out inventory) &&
                ValidateNumericInput(priceText, out price) &&
                ValidateNumericInput(textBox6Text, out max) &&
                ValidateNumericInput(textBox5Text, out min))
            {
                Console.WriteLine("Validation passed");

                if (min > max)
                {
                    MessageBox.Show("Your minimum exceeds your maximum.");
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;

                    ModifiedName = textBox2.Text;
                    ModifiedPrice = decimal.Parse(textBox4.Text);
                    ModifiedInStock = int.Parse(textBox3.Text);
                    ModifiedMin = int.Parse(textBox5.Text);
                    ModifiedMax = int.Parse(textBox6.Text);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Validation failed");
                button3.Enabled = false;
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}