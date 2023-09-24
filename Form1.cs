using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListClass.MyList;
            dataGridView2.DataSource = ProductsList.MyList;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 218, 185);
            bool found = false;
            string searchText = textBox1.Text.Trim();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Country = new Form3();

            Country.textBox1.Text = "";
            Country.textBox2.Text = "";
            Country.textBox3.Text = "";
            Country.textBox4.Text = "";

            Country.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Country = new Form3();

            Country.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Country.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Country.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Country.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Country.textBox1.ReadOnly = true;
            Country.textBox5.Text = "F&K Autobody";
            Country.textBox6.Text = "25";
            Country.textBox7.Text = "20";

            if (ContainsNumeric(textBox2.Text))
            {
                MessageBox.Show("String is required");
                textBox2.BackColor = System.Drawing.Color.IndianRed;
            }

            Country.ShowDialog();

        }

        public bool ContainsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 218, 185);
            bool found = false;
            string searchText = textBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                for (int i = 0; i < ProductsList.MyList.Count; i++)
                {
                    string productName = ProductsList.MyList[i].ProductName.Trim();
                    if (productName.ToUpper().Contains(searchText.ToUpper()))
                    {
                        dataGridView2.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
