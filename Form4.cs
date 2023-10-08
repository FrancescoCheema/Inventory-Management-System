using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Francesco_Cheema___Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            button1.Enabled = false;

            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;
            textBox4.TextChanged += TextBox_TextChanged;
            textBox6.TextChanged += TextBox_TextChanged;
            textBox7.TextChanged += TextBox_TextChanged;

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox2.Text;

            if (string.IsNullOrEmpty(s))
            {
                textBox2.BackColor = System.Drawing.Color.IndianRed;
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                textBox5.BackColor = System.Drawing.Color.IndianRed;
                textBox6.BackColor = System.Drawing.Color.IndianRed;
                textBox7.BackColor = System.Drawing.Color.IndianRed;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox2.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsDigit))
            {
                textBox2.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox2, "Name is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

                string s = textBox5.Text;

                if (string.IsNullOrWhiteSpace(s) || s.All(Char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Price is required");
                    toolTip1.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }

            if (radioButton2.Checked)
            {
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

                string s = textBox5.Text;

                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Company Name Required");
                    toolTip1.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }
            
        }

        private void textBox5_Validating(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

                string s = textBox5.Text;

                if (string.IsNullOrWhiteSpace(s) || s.All(Char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Price is required");
                    toolTip1.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }

            if (radioButton2.Checked)
            {
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

                string s = textBox5.Text;

                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Company Name Required");
                    toolTip1.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox3.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox3, "Inventory is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox4.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox4, "Price is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button1WasClicked = true;

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox7.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox7.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox7, "Price is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox7.BackColor = System.Drawing.Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool button1WasClicked = false;

        private int SelectedRowIndex;

        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string partName = textBox2.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox7Text = textBox7.Text;

            if (!string.IsNullOrEmpty(partName) &&
                !string.IsNullOrEmpty(inventoryText) &&
                !string.IsNullOrEmpty(priceText) &&
                !string.IsNullOrEmpty(textBox6Text) &&
                !string.IsNullOrEmpty(textBox7Text))
            {
                if (ValidateNumericInput(inventoryText, out int inventory) &&
                   ValidateNumericInput(priceText, out int Price) &&
                   ValidateNumericInput(textBox6Text, out int value6) &&
                   ValidateNumericInput(textBox7Text, out int value7))
                {
                    if(inventory > value6 && button1WasClicked)
                    {
                        MessageBox.Show("Your minimum exceeds your maximum.");
                    }
                    else
                    {
                        UpdateDataSource(SelectedRowIndex, partName, inventory, Price);
                        Form1 form1 = Application.OpenForms()
                    }
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            else
            {
                button1.Enabled= false;
            }
             
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox6.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox6.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox6, "Price is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
