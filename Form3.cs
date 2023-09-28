using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form3 : Form
    {
        public Form3()
        {
        InitializeComponent();

            textBox2.TextChanged += textBox2_TextChanged;

        }

        public static void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox2.Text, out _))
            {
                textBox2.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }

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

            ToolTip toolTip1 = new ToolTip();

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
    }
}
