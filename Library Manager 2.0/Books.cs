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
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            columnHeaderDDS.Width = 150;
            columnHeaderTitle.Width = 155;
            columnHeaderAuthor.Width = 135;
            columnHeaderCategory.Width = 110;
            columnHeaderDateAdded.Width = 120;
            columnHeaderYoP.Width = 120;
            columnHeaderAvailability.Width = 105;
        }
    }
}
