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

        private void Form2_Load(object sender, EventArgs e)
        {

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
    }
}
