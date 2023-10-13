using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;
            textBox4.TextChanged += TextBox_TextChanged;
            textBox5.TextChanged += TextBox_TextChanged;
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
                toolTip1.SetToolTip(textBox7, "Minimum is required");
                toolTip1.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                textBox7.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            string s = textBox5.Text;

            if (radioButton1.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || s.All(Char.IsDigit))
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Price is required");
                    toolTip1.ForeColor = System.Drawing.Color.Gray;
                }
            }
            else if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(s) || s.All(char.IsLetter))
                {
                    textBox5.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    textBox5.BackColor = System.Drawing.Color.IndianRed;
                    toolTip1.SetToolTip(textBox5, "Company Name Required");
                    toolTip1.BackColor = System.Drawing.Color.Gray;
                }
            }
        }


        private bool button1WasClicked = true;

        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private int lastPartID = 3;

        private void button1_click(object sender, EventArgs e)
        {
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

                    int maxPartID = ListClass.MyList.Max(p => p.PartID);
                    int nextPartID = maxPartID + 1;

                    Parts newPart = new Parts(nextPartID, partName, inventory, price, value7, max , idorcompany);
                    ListClass.MyList.Add(newPart);

                    Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                    form1.dataGridView1.DataSource = null;
                    form1.dataGridView1.DataSource = ListClass.MyList;

                    MessageBox.Show("Your changes have been successfully saved.");
                    this.Close();
                }
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string partName = textBox2.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox7Text = textBox7.Text;
            int price = 0;
            int inventory = 0;

            bool allFieldsEntered = !string.IsNullOrEmpty(partName) &&
                                    !string.IsNullOrEmpty(inventoryText) &&
                                    !string.IsNullOrEmpty(priceText) &&
                                    !string.IsNullOrEmpty(textBox6Text) &&
                                    !string.IsNullOrEmpty(textBox7Text);

            if (allFieldsEntered)
            {
                if (ValidateNumericInput(inventoryText, out inventory) &&
                    ValidateNumericInput(priceText, out price) &&
                    ValidateNumericInput(textBox6Text, out int value6) &&
                    ValidateNumericInput(textBox7Text, out int value7))
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
                            button1.Enabled = false;
                        }
                        else
                        {
                            textBox5.BackColor = System.Drawing.Color.White;
                            button1.Enabled = true;
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
                            button1.Enabled = false;
                        }
                        else
                        {
                            textBox5.BackColor = System.Drawing.Color.White;
                            button1.Enabled = true;
                        }
                    }
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            else
            {
                button1.Enabled = false;
            }
        }

    }
    }







