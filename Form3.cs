using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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

                if (string.IsNullOrWhiteSpace(s) || s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Machine ID Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White;
            }


            if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || !s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    tooltip1.SetToolTip(textBox5, "Company Name Required");
                    tooltip1.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White;
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Changes Saved Successfully.");

            this.Close();
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

            if (s.All(Char.IsLetter))
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
            textBox5.Text = "F Autobody";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
            textBox5.Text = "F Autobody";
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
    }
}
