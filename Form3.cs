using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Francesco_Cheema___Inventory
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            textBox2.TextChanged += textBox2_TextChanged;

        }

        public event Action<string> TextChangedInForm2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            TextChangedInForm2?.Invoke(s);
        }

        public static void label3_Click(object sender, EventArgs e)
        {

        }

        public static void label4_Click(object sender, EventArgs e)
        {

        }

        public static void label8_Click(object sender, EventArgs e)
        {

        }

        public static void Form3_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_Validating(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox5.Text;

            if (radioButton1.Checked)
            {

                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsDigit))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Machine ID Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }
            }

            else if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Company Name Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private int SelectedRowIndex;

        private bool button1WasClicked = true;

        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            ListClass.MyList[SelectedRowIndex].PartName = textBox2.Text;

            ListClass.MyList[SelectedRowIndex].Inventory = Int32.Parse(textBox3.Text);

            ListClass.MyList[SelectedRowIndex].Price = Int32.Parse(textBox4.Text);

            ListClass.MyList[SelectedRowIndex].Max = Int32.Parse(textBox6.Text);

            ListClass.MyList[SelectedRowIndex].Value7 = Int32.Parse(textBox7.Text);

            if (radioButton1.Checked)
            {
                ListClass.MyList[SelectedRowIndex].IdOrCompany = Int32.Parse(textBox5.Text).ToString();
            }
            else
            {
                ListClass.MyList[SelectedRowIndex].IdOrCompany = textBox5.Text;
            }

            string partName = textBox2.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox7Text = textBox7.Text;
            int price = 0;
            int inventory = 0;
            int max = 0;
            int value7 = 0;
            string idorcompany = textBox5.Text;


            bool allFieldsEntered = !string.IsNullOrEmpty(partName) &&
                                    !string.IsNullOrEmpty(inventoryText) &&
                                    !string.IsNullOrEmpty(priceText) &&
                                    !string.IsNullOrEmpty(textBox6Text) &&
                                    !string.IsNullOrEmpty(textBox7Text);


            if (ValidateNumericInput(inventoryText, out inventory) &&
                    ValidateNumericInput(priceText, out price) &&
                    ValidateNumericInput(textBox6Text, out max) &&
                    ValidateNumericInput(textBox7Text, out value7))

                if (value7 > max && button1WasClicked)
                {
                    MessageBox.Show("Your minimum exceeds your maximum.");
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;

                    Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                    if (form1 != null)
                    {
                        form1.dataGridView1.Refresh();
                    }

                    MessageBox.Show("Changes Saved Successfully");

                    this.Close();
                }
            else
            {
                button1.Enabled = false;
            }
    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox3.Text;

            if (s.All(Char.IsLetter))
            {
                textBox3.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox3, "Inventory number is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button1.Enabled = false;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
                button1.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox4.Text;

            if (s.All(Char.IsLetter))
            {
                textBox4.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox4, "Price is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button1.Enabled = false;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
                button1.Enabled = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";

            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox5.Text;

            if (radioButton1.Checked)
            {

                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsDigit))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Machine ID Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }
            }

            else if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Company Name Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox5.Text;

            if (radioButton1.Checked)
            {

                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsDigit))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Machine ID Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }
            }

            else if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Company Name Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                    button1.Enabled = false;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                    button1.Enabled = true;
                    tooltip1.Active = false;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox2.Text;

            if(string.IsNullOrEmpty(s) || s.All(char.IsDigit))
            {
                textBox2.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox2, "Name Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox6.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox6.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox6, "Maximum is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button1.Enabled = false;
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
                button1.Enabled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            string s = textBox7.Text;

            if (string.IsNullOrEmpty(s) || s.All(Char.IsLetter))
            {
                textBox7.BackColor = System.Drawing.Color.IndianRed;
                toolTip1.SetToolTip(textBox7, "Minimum is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
                button1.Enabled = false;
            }
            else
            {
                textBox7.BackColor = System.Drawing.Color.White;
                button1.Enabled = true;
            }
        }
    }
}
