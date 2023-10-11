using System;
using System.Linq;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            button1.Enabled = false;

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

        private bool ValidateTextBox5ForPrice()
        {
            string s = textBox5.Text;

            if (string.IsNullOrWhiteSpace(s) || s.All(Char.IsLetter))
            {
                SetTextBoxError("Price Required");
                return false;
            }

            ClearTextBox5Error();
            return true;
        }

        private bool ValidateTextBox5ForCompanyName()
        {
            string s = textBox5.Text;

            if (string.IsNullOrWhiteSpace(s) || s.All(Char.IsLetter))
            {
                SetTextBoxError("Company Name Required");
                return false;
            }

            ClearTextBox5Error();
            return true;
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

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool button1WasClicked = true;

        private bool ValidateNumericInput(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private int lastPartID = 3;

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

        private void button1_click(object sender, EventArgs e)
        {

        }

        private void TextBox_TexChanged(object sender, EventArgs e)
        {
            string partName = textBox2.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox7Text = textBox7.Text;
            int price = 0;

            if (!string.IsNullOrEmpty(partName) &&
                !string.IsNullOrEmpty(inventoryText) &&
                !string.IsNullOrEmpty(priceText) &&
                !string.IsNullOrEmpty(textBox6Text) &&
                !string.IsNullOrEmpty(textBox7Text))
            {
                if (ValidateNumericInput(inventoryText, out int inventory) &&
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
                int maxPartID = ListClass.MyList.Max(p => p.PartID);

                int nextPartID = maxPartID + 1;

                Parts newPart = new Parts(nextPartID, partName, inventory, price);

                ListClass.MyList.Add(newPart);

                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                form1.dataGridView1.DataSource = null;
                form1.dataGridView1.DataSource = ListClass.MyList;

                MessageBox.Show("Your changes have been successfully saved.");
                this.Close();
            }
        }
    }


    private void EnableButton()
        {
            button1.Enabled = true;
        }

        private void SetTextBoxError(string errorMessage)
        {
            textBox5.BackColor = System.Drawing.Color.IndianRed;
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();
            tooltip1.SetToolTip(textBox5, errorMessage);
            tooltip1.ForeColor = System.Drawing.Color.Gray;
            button1.Enabled = false;
        }

        private void ClearTextBox5Error()
        {
            textBox5.BackColor= System.Drawing.Color.Gray;
            EnableButton();
        }

        private bool ValidateInputFields()
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
                return false;
            }

            if (ValidateNumericInput(inventoryText, out int inventory) &&
              ValidateNumericInput(priceText, out int Price) &&
              ValidateNumericInput(textBox6Text, out int value6) &&
              ValidateNumericInput(textBox7Text, out int value7))
            {
                return false;
            }

            if (radioButton1.Checked)
            {
                return ValidateTextBox5ForPrice();
            }
            else if (radioButton2.Checked)
            {
                return ValidateTextBox5ForCompanyName();
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string partName = textBox2.Text;
            string inventoryText = textBox3.Text;
            string priceText = textBox4.Text;
            string textBox6Text = textBox6.Text;
            string textBox7Text = textBox7.Text;
            int price = 0;

            if (!string.IsNullOrEmpty(partName) &&
                !string.IsNullOrEmpty(inventoryText) &&
                !string.IsNullOrEmpty(priceText) &&
                !string.IsNullOrEmpty(textBox6Text) &&
                !string.IsNullOrEmpty(textBox7Text))
            {
                if (ValidateNumericInput(inventoryText, out int inventory) &&
                    ValidateNumericInput(priceText, out price) &&
                    ValidateNumericInput(textBox6Text, out int value6) &&
                    ValidateNumericInput(textBox7Text, out int value7))
                {
                    button1.Enabled = false;
                
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
                else if(button1.Click == true)
                {
                    button1.Enabled = true;

                    int maxPartID = ListClass.MyList.Max(p => p.PartID);

                    int nextPartID = maxPartID + 1;

                    Parts newPart = new Parts(nextPartID, partName, inventory, price);

                    ListClass.MyList.Add(newPart);

                    Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                    form1.dataGridView1.DataSource = null;
                    form1.dataGridView1.DataSource = ListClass.MyList;

                    MessageBox.Show("Your changes have been successfully saved.");
                    this.Close();
                }
            }
        }
    }
}


