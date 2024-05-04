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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            columnHeaderStudentNumber.Width = 90;
            columnHeaderName.Width = 170;
            columnHeaderCYS.Width = 115;
            columnHeaderBook.Width = 175;
            columnHeaderDateBorrowed.Width = 100;
            columnHeaderDateReturned.Width = 100;
        }
    }
}
