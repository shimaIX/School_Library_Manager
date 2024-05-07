using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Library_Manager
{
    public partial class Add_Transaction : Form
    {
        public Add_Transaction()
        {
            InitializeComponent();
        }

        private void pictureBox_UpdateBook_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_UpdateBook_Clear_Click(object sender, EventArgs e)
        {
            if (textBox_StudentNo.ForeColor != Color.Red)
            {
                textBox_StudentNo.Text = "";
            }
            if (textBox_Name.ForeColor != Color.Red)
            {
                textBox_Name.Text = "";
            }
            if (textBox_CYS.ForeColor != Color.Red)
            {
                textBox_CYS.Text = "";
            }
            if (textBox_BookBorrowed.ForeColor != Color.Red)
            {
                textBox_BookBorrowed.Text = "";
            }
            if (pictureBoxError7.Visible != true)
            {
                comboBoxStatus.SelectedIndex = -1;
            }
        }

        private void label_UpdateBook_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_Transaction_Load(object sender, EventArgs e)
        {
            dateTimePickerReturnedDate.Enabled = false;
        }

        private void checkBoxAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdd.Checked == true)
            {
                dateTimePickerReturnedDate.Enabled = true;
            }
            else
            {
                dateTimePickerReturnedDate.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            checkIfEmptyOrNot();

            if(!(studetnum == false || name == false || year == false || course == false || section == false || bookborrowed == false || status == false))
            {
                return;
            }

            if (textBox_StudentNo.ForeColor != Color.Black || textBox_Name.ForeColor != Color.Black || textBox_CYS.ForeColor != Color.Black || textBox_BookBorrowed.ForeColor != Color.Black || comboBoxStatus.SelectedIndex == -1)
            {
                return;
            }

            string addStudentNo = textBox_StudentNo.Text;
            string addName = textBox_Name.Text;
            string addCourse = textBox_CYS.Text;
            string addBookBorrowed = textBox_BookBorrowed.Text;
            DateTime currentTime = dateTimePicker1.Value;
            string addBorrowedDate = currentTime.ToString(); 
            string addStatus = comboBoxStatus.SelectedItem.ToString();

            string addReturnedDate = "";
            if (checkBoxAdd.Checked == true)
            {
                currentTime = dateTimePickerReturnedDate.Value;
                addReturnedDate = currentTime.ToString();
            }
            else
            {
                addReturnedDate = "";
            }

            //Database._Instance.DatabaseOfBooks.Rows.Add(deweyDecimalSystem, title, author, category, year, date, availability);
            Database._Instance.DatabaseOfTransaction.Rows.Add(addStudentNo, addName, addCourse, addBookBorrowed, addBorrowedDate,addReturnedDate,addStatus);

            this.Hide();
            MessageBox.Show("You successfully added a transaction.");
        }

        bool studetnum = false;
        bool name = false;
        bool year = false;
        bool course = false;
        bool section = false;
        bool bookborrowed = false;
        bool status = false;
        
        private void checkIfEmptyOrNot()
        {
            if(textBox_StudentNo.Text == "")
            {
                textBox_StudentNo.Text = "Please type the student number.";
                textBox_StudentNo.ForeColor = Color.Red;
                pictureBoxError1.Visible = true;
                studetnum = true;
            }
            else
            {
                studetnum = false;
            }

            if(textBox_Name.Text == "")
            {
                textBox_Name.Text = "Please type the name of student.";
                textBox_Name.ForeColor = Color.Red;
                pictureBoxError2.Visible = true;
                name = true;
            }
            else
            {
                name = false;
            }

            if (textBox_CYS.Text == "")
            {
                textBox_CYS.Text = "Type the Course/Year/Section of student.";
                textBox_CYS.ForeColor = Color.Red;
                pictureBoxError3.Visible = true;
                year = true;
            }
            else
            {
                year = false;
            }

            if (textBox_BookBorrowed.Text == "")
            {
                textBox_BookBorrowed.Text = "Please type the name of the borrowed book.";
                textBox_BookBorrowed.ForeColor = Color.Red;
                pictureBoxError6.Visible = true;
                bookborrowed = true;
            }
            else
            {
                bookborrowed = false;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                lblErrorMessage1.Visible = true;
                pictureBoxError7.Visible = true;
                status = true;
            }
            else
            {
                status = false;
            }
        }

        private void textBox_StudentNo_Click(object sender, EventArgs e)
        {
            if (textBox_StudentNo.ForeColor != Color.Black)
            {
                pictureBoxError1.Visible = false;
                textBox_StudentNo.Text = "";
                textBox_StudentNo.ForeColor = Color.Black;
                textBox_StudentNo.Select();
            }
            else
            {
                return;
            }
        }

        private void textBox_Name_Click(object sender, EventArgs e)
        {
            if (textBox_Name.ForeColor != Color.Black)
            {
                pictureBoxError2.Visible = false;
                textBox_Name.Text = "";
                textBox_Name.ForeColor = Color.Black;
                textBox_Name.Select();
            }
            else
            {
                return;
            }
        }

        private void textBox_Year_Click(object sender, EventArgs e)
        {
            if (textBox_CYS.ForeColor != Color.Black)
            {
                pictureBoxError3.Visible = false;
                textBox_CYS.Text = "";
                textBox_CYS.ForeColor = Color.Black;
                textBox_CYS.Select();
            }
            else
            {
                return;
            }
        }

        private void textBox_BookBorrowed_Click(object sender, EventArgs e)
        {
            if (textBox_BookBorrowed.ForeColor != Color.Black)
            {
                pictureBoxError6.Visible = false;
                textBox_BookBorrowed.Text = "";
                textBox_BookBorrowed.ForeColor = Color.Black;
                textBox_BookBorrowed.Select();
            }
            else
            {
                return;
            }
        }

        private void lblErrorMessage1_Click(object sender, EventArgs e)
        {
            lblErrorMessage1.Visible = false;
            pictureBoxError7.Visible = false;
            comboBoxStatus.DroppedDown = true;
        }

        private void comboBoxStatus_Click(object sender, EventArgs e)
        {
            lblErrorMessage1.Visible = false;
            pictureBoxError7.Visible = false;
            comboBoxStatus.DroppedDown = true;
        }

        private void pictureBoxError4_Click(object sender, EventArgs e)
        {
                    }
    }
}
