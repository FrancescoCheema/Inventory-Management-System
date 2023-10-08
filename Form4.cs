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

        private bool button1WasClicked = false;

        private int SelectedRowIndex;

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;

            if (!string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text))
            {
                Form1 form = new Form1();

                button1.Enabled = true;

                ListClass.MyList[SelectedRowIndex].PartName = textBox2.Text;

                ListClass.MyList[SelectedRowIndex].Inventory = Int32.Parse(textBox3.Text);

                ListClass.MyList[SelectedRowIndex].Price = Int32.Parse(textBox4.Text);

                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                if (form1 != null)
                {
                    form1.dataGridView1.Refresh();
                }

                MessageBox.Show("Changes Saved Successfully");

                this.Close();

            }
            else if (string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text))
            {
                button1.Enabled = false;
            }
            else if (Int32.TryParse(textBox7.Text, out int value7) && int.TryParse(textBox6.Text, out int value6))
            {
                if (value7 > value6 && button1WasClicked == true)
                {
                    MessageBox.Show("Your minimum exceeds your maximum. ");
                }
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
    }
}
