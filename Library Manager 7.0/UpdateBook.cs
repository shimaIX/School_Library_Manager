using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_UpdateBook_Help_MouseHover(object sender, EventArgs e)
        {
            label_UpdateBook_Help.Visible = true;
        }

        private void pictureBox_UpdateBook_Help_MouseLeave(object sender, EventArgs e)
        {
            label_UpdateBook_Help.Visible = false;
        }

        private void pictureBox_UpdateBook_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label_UpdateBook_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_UpdateBook_Clear_Click(object sender, EventArgs e)
        {
            if (textBox_UpdateBook_DDS.ForeColor != Color.Red)
            {
                textBox_UpdateBook_DDS.Text = "";
            }

            if (textBox_UpdateBook_Title.ForeColor != Color.Red)
            {
                textBox_UpdateBook_Title.Text = "";
            }

            if (textBox_UpdateBook_Author.ForeColor != Color.Red)
            {
                textBox_UpdateBook_Author.Text = "";
            }

            if (textBox_UpdateBook_Year.ForeColor != Color.Red)
            {
                textBox_UpdateBook_Year.Text = "";
            }
        }

        private void button_UpdateBook_Update_Click(object sender, EventArgs e)
        {

        }

        
    }
}
