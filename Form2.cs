using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            dataGridView1.DataSource = ListClass.MyList;

            dataGridView2.Columns.Add("PartID", "Part ID");

            dataGridView2.Columns.Add("PartName", "Part Name");

            dataGridView2.Columns.Add("Inventory", "Inventory");

            dataGridView2.Columns.Add("Price", "Price");
        }

        private bool button3WasClicked = true;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedrow.Cells[0].Value });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedrow.Cells[1].Value });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedrow.Cells[2].Value });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedrow.Cells[3].Value });

                dataGridView2.Rows.Add(newRow);
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
                    string partName = ListClass.MyList[i].PartName.Trim();
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

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            ProductsList.MyList[SelectedRowIndex].ProductName = textBox2.Text.ToString();
            ProductsList.MyList[SelectedRowIndex].Inventory = Int32.Parse(textBox3.Text);
            ProductsList.MyList[SelectedRowIndex].Price = Int32.Parse(textBox4.Text);
            ProductsList.MyList[SelectedRowIndex].Max = Int32.Parse(textBox6.Text);
            ProductsList.MyList[SelectedRowIndex].Min = Int32.Parse(textBox5.Text);

            string maxText = textBox6.Text;
            string minText = textBox5.Text;
            int max = 0;
            int min = 0;

            if (ValidateNumericInput(maxText, out max) &&
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

                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                if (form1 != null)
                {
                    form1.dataGridView1.Refresh();
                }
                MessageBox.Show("Changes Saved Successfully");
                this.Close();
            }

            else if (button3WasClicked && dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Must have at least one associated part.");
            }
        }
    }
}
