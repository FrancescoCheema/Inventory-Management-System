using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Francesco_Cheema___Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ListClass.MyList;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 231, 64);

            dataGridView2.DataSource = ProductsList.MyList;

            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 231, 64);

            synchronizationContext = SynchronizationContext.Current;
        }

        public SynchronizationContext synchronizationContext;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = false;
            }

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.Visible = false;
            }

            dataGridView2.Columns[0].Visible = true;
            dataGridView2.Columns[1].Visible = true;
            dataGridView2.Columns[2].Visible = true;
            dataGridView2.Columns[3].Visible = true;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 231, 64);
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

        private bool button1WasClicked = false;

        private int SelectedRowIndex;

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 addPart = new Form4();

            addPart.textBox1.ReadOnly = true;

            addPart.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 231, 64);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Form3 Country = new Form3();

                Country.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Country.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Country.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Country.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Country.textBox1.ReadOnly = true;
                Country.textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Country.textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Country.textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                Country.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }
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
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 231, 64);
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

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);

                    Parts itemToRemove = ListClass.MyList.FirstOrDefault(item => item.PartID == partID);
                    if (itemToRemove != null)
                    {
                        ListClass.MyList.Remove(itemToRemove);
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListClass.MyList;
                }
            }
            else
            {
                MessageBox.Show("No row is selected to delete.");
            }
        }

        private void deletebtn2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                    int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                    Products itemToRemove = ProductsList.MyList.FirstOrDefault(item => item.ProductID == productID);
                    if (itemToRemove != null)
                    {
                        ProductsList.MyList.Remove(itemToRemove);
                    }

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = ProductsList.MyList;
                }
            }
            else
            {
                MessageBox.Show("No row is selected to delete.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                Form2 form = new Form2();

                form.textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                form.textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                form.textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

                form.textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

                form.textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

                form.textBox6.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

                form.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
