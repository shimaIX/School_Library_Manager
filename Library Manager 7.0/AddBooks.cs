using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            //forComboBoxCategory();
            //forComboBoxAvailability();

        }

        private void forComboBoxCategory()
        {
            comboBoxCategory.Items.Add("Generalities");
            comboBoxCategory.Items.Add("Philosophy and Psychology");
            comboBoxCategory.Items.Add("Religion");
            comboBoxCategory.Items.Add("Social Sciences");
            comboBoxCategory.Items.Add("Language");
            comboBoxCategory.Items.Add("Natural Science and Mathematics");
            comboBoxCategory.Items.Add("Technology (Applied Sciences)");
            comboBoxCategory.Items.Add("Arts");
            comboBoxCategory.Items.Add("Literature");
            comboBoxCategory.Items.Add("Geography and History");
        }

        private void forComboBoxAvailability()
        {
            comboBoxAvailability.Items.Add("On-shelf");
            comboBoxAvailability.Items.Add("Borrowed");
            comboBoxAvailability.Items.Add("Missing");
        }

        public bool successfullyAdded = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBook_btnAdd_Click(object sender, EventArgs e)
        {   
            checkIfEmptyOrNot();

            if (!(checkAuthor == false || checkAvailability == false || checkCategory == false || checkDDS == false || checkTitle == false || checkYear == false))
            {
                return;
            }
            if(textBoxDDS.ForeColor != Color.Black || textBoxTitle.ForeColor != Color.Black || textBoxAuthor.ForeColor != Color.Black || textBoxYear.ForeColor != Color.Black || comboBoxCategory.SelectedIndex == -1 || comboBoxAvailability.SelectedIndex == -1)
            {
                return;
            }
            
            string deweyDecimalSystem = textBoxDDS.Text;
            string title = textBoxTitle.Text;
            string category = comboBoxCategory.SelectedItem.ToString();
            string author = textBoxAuthor.Text;
            string year = textBoxYear.Text;
            //DateTime currentTime = dateTimePicker1.Value;
            //dateTimePicker1.Value = currentTime;
            string date = dateTimePicker1.Value.ToString();
            string availability = comboBoxAvailability.SelectedItem.ToString();

            //Database._Instance.ColumnsForDataGrideView1();
            Database._Instance.DatabaseOfBooks.Rows.Add(deweyDecimalSystem, title, author, category, year, date, availability);

            successfullyAdded = true;

            this.Hide();
            MessageBox.Show("You successfully added a book.");
        }

        bool checkTitle = false;
        bool checkAuthor = false;
        bool checkDDS= false;
        bool checkYear = false;
        bool checkCategory = false;
        bool checkAvailability = false;

        private void checkIfEmptyOrNot()
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Please type the title of the book!";
                textBoxTitle.ForeColor = Color.Red;
                pictureBoxError1.Visible = true;
                checkTitle = true;
            }
            else
            {
                checkTitle = false;
            }

            if (textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Please type the name of the author!";
                textBoxAuthor.ForeColor = Color.Red;
                pictureBoxError2.Visible = true;
                checkAuthor = true;
            }
            else
            {
                checkAuthor = false;
            }

            if (textBoxDDS.Text == "")
            {
                textBoxDDS.Text = "Please type the DDS of the book!";
                textBoxDDS.ForeColor = Color.Red;
                pictureBoxError3.Visible = true;
                checkDDS = true;
            }
            else
            {
                checkDDS = false;
            }

            if (textBoxYear.Text == "")
            {
                textBoxYear.Text = "Please type the year of publication!";
                textBoxYear.ForeColor = Color.Red;
                pictureBoxError4.Visible = true;
                checkYear = true;
            }
            else
            {
                checkYear = false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                lblErrorMessage3.Visible = true;
                pictureBoxError5.Visible = true;
                checkCategory = true;
            }
            else 
            {
                checkCategory = false;
            }

            if (comboBoxAvailability.SelectedIndex == -1)
            {
                lblErrorMessage4.Visible = true;
                pictureBoxError6.Visible = true;
                checkAvailability = true;
            }
            else
            {
                checkAvailability = false;
            }

            
        }

        private void textBoxDDS_Click(object sender, EventArgs e)
        {
            if(textBoxDDS.ForeColor != Color.Black)
            {
                pictureBoxError3.Visible = false;
                textBoxDDS.Text = "";
                textBoxDDS.ForeColor = Color.Black;
                textBoxDDS.Select();
            }
            else
            {
                return;
            }
            
        }

        private void textBoxYear_Click(object sender, EventArgs e)
        {
            if(textBoxYear.ForeColor != Color.Black)
            {
                pictureBoxError4.Visible = false;
                textBoxYear.Text = "";
                textBoxYear.ForeColor = Color.Black;
                textBoxYear.Select();
            }
            else
            {
                return;
            }
            
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.ForeColor != Color.Black)
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
                pictureBoxError1.Visible = false;
                textBoxTitle.Select();
            }
            else
            {
                return;
            }
        }

        private void textBoxAuthor_Click(object sender, EventArgs e)
        {
            if (textBoxAuthor.ForeColor != Color.Black)
            {
                textBoxAuthor.Text = "";
                textBoxAuthor.ForeColor = Color.Black;
                pictureBoxError2.Visible = false;
                textBoxAuthor.Select();
            }
            else
            {
                return;
            }
        }

        private void comboBoxCategory_Click(object sender, EventArgs e)
        {
            lblErrorMessage3.Visible = false;
            pictureBoxError5.Visible = false;
            comboBoxCategory.DroppedDown = true;
        }

        private void lblErrorMessage3_Click(object sender, EventArgs e)
        {
            lblErrorMessage3.Visible = false;
            pictureBoxError5.Visible = false;
            comboBoxCategory.DroppedDown = true;
        }

        private void comboBoxAvailability_Click(object sender, EventArgs e)
        {
            lblErrorMessage4.Visible = false;
            pictureBoxError6.Visible = false;
            comboBoxAvailability.DroppedDown = true;
        }

        private void lblErrorMessage4_Click(object sender, EventArgs e)
        {
            lblErrorMessage4.Visible = false;
            pictureBoxError6.Visible = false;
            comboBoxAvailability.DroppedDown = true;
        }

        private void textBoxDDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDDSAndYear(sender,e);
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDDSAndYear(sender, e);
        }

        private void forDDSAndYear(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void AddBook_btnClear_Click(object sender, EventArgs e)
        {
            if(textBoxDDS.ForeColor != Color.Red)
            {
                textBoxDDS.Text = "";
            }

            if(textBoxTitle.ForeColor != Color.Red)
            {
                textBoxTitle.Text = "";
            }

            if(textBoxAuthor.ForeColor != Color.Red && textBoxAuthor.Text != "N/A")
            {
                textBoxAuthor.Text = "";
            }

            if (textBoxYear.ForeColor != Color.Red && textBoxAuthor.Text != "N/A")
            {
                textBoxYear.Text = "";
            }

            if(lblErrorMessage3.Visible != true)
            {
                comboBoxCategory.SelectedIndex = -1;
            }

            if (lblErrorMessage4.Visible != true)
            {
                comboBoxAvailability.SelectedIndex = -1;
            }
        }

        private void AddBook_btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            labelHelp.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.Visible = false;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNA2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNA2.Checked == true)
            {
                textBoxYear.Text = "N/A";
                textBoxYear.ForeColor = Color.Black;
                textBoxYear.Enabled = false;
                pictureBoxError4.Visible = false;
            }
            else
            {
                textBoxYear.Enabled = true;
                textBoxYear.Clear();
            }
        }

        private void checkBoxNA3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNA3.Checked == true)
            {
                textBoxAuthor.Text = "N/A";
                textBoxAuthor.ForeColor = Color.Black;
                textBoxAuthor.Enabled = false;
                pictureBoxError2.Visible = false;
            }
            else
            {
                textBoxAuthor.Enabled = true;
                textBoxAuthor.Clear();
            }
        }
    }
}
