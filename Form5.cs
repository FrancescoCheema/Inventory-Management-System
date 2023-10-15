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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox2.Text;

            if (string.IsNullOrEmpty(s) || s.All(char.IsDigit))
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            string s = textBox2.Text;

            if (string.IsNullOrEmpty(s) || !s.All(char.IsDigit))
            {
                textBox2.BackColor = System.Drawing.Color.IndianRed;
                tooltip1.SetToolTip(textBox2, "Inventory Required");
                tooltip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
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
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.White;
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
            }
            else
            {
                textBox6.BackColor = System.Drawing.Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DataGridViewRow SelectedRow = dataGridView2.SelectedRows[0];

                    int partID = Convert.ToInt32(SelectedRow.Cells["PartID"].Value);
                    Parts itemToRemove = ListClass.MyList.FirstOrDefault(item => item.PartID == partID);
                    if (itemToRemove != null)
                    {
                        ListClass.MyList.Remove(itemToRemove);
                    }

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = ListClass.MyList;
                }
            }
            else
            {
                MessageBox.Show("No row is selected to delete.");
            }
        }
    }
}
