using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            forComboBoxCategory();
            forComboBoxAvailability();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBook_btnAdd_Click(object sender, EventArgs e)
        {
            if(textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Please type the title of the book!";
                textBoxTitle.ForeColor = Color.Red;
                pictureBoxError1.Visible = true;
            }
            if(textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Please type the name of the author!";
                textBoxAuthor.ForeColor = Color.Red;
                pictureBoxError2.Visible = true;
            }
            if(maskedTextBoxDDS.Text == "")
            {
                lblErrorMessage1.Visible = true;
                pictureBoxError3.Visible = true;
            }
            if(maskedTextBoxYear.Text == "")
            {
                lblErrorMessage2.Visible = true;
                pictureBoxError4.Visible = true;
            }
            if(comboBoxCategory.SelectedIndex == -1)
            {
                lblErrorMessage3.Visible = true;
                pictureBoxError5.Visible = true;
            }
            if (comboBoxAvailability.SelectedIndex == -1)
            {
                lblErrorMessage4.Visible = true;
                pictureBoxError6.Visible = true;
            }
        }

        private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxTitle.ForeColor != Color.Black)
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }

            
        }

        private void textBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxTitle.ForeColor != Color.Black)
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }
            pictureBoxError2.Visible = false;
        }

        private void lblErrorMessage1_Click(object sender, EventArgs e)
        {
            lblErrorMessage1.Visible = false;
            pictureBoxError3.Visible = false;
            maskedTextBoxDDS.Select();
        }

        private void lblErrorMessage2_Click_1(object sender, EventArgs e)
        {
            lblErrorMessage2.Visible = false;
            pictureBoxError4.Visible = false;
            maskedTextBoxYear.Select();
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxTitle.ForeColor = Color.Black;
            pictureBoxError1.Visible = false;
            textBoxTitle.Select();
        }

        private void textBoxAuthor_Click(object sender, EventArgs e)
        {
            textBoxAuthor.Text = "";
            textBoxAuthor.ForeColor = Color.Black;
            pictureBoxError2.Visible = false;
            textBoxAuthor.Select();
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
    }
}
