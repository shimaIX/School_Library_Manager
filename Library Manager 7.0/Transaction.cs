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
            dataGridView1.DataSource = Database._Instance.DatabaseOfTransaction;
            Database._Instance.ColumnsForDatabaseOfTranasction();
            ColumnsForDataGrideView1Width();
            PreDefinedRowsForDataGridView1();
            defaultCheckedRadioButton();
        }

        private void ColumnsForDataGrideView1Width()
        {
            //dataGridView1.Columns[0].Width = 150;
            //dataGridView1.Columns[1].Width = 150;
            //dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[3].Width = 150;
            //dataGridView1.Columns[4].Width = 140;
            //dataGridView1.Columns[5].Width = 100;
            //dataGridView1.Columns[6].Width = 150;

            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 130;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void PreDefinedRowsForDataGridView1()
        {
            Database._Instance.DatabaseOfTransaction.Rows.Add("0323-3495", "Raymund Yanni Hernandez", "BSCS - 1A", "Le Miserable", "05/04/2024 00:00:00 am", "N/A", "Borrowed");
            Database._Instance.DatabaseOfTransaction.Rows.Add("0323-3518", "Ricci Zasha Gandia", "BSCS - 1A", "To Kill a Mockingbird", "29/08/2022 00:00:00 am", "05/02/2024 00:00:00 am", "Returned");
            Database._Instance.DatabaseOfTransaction.Rows.Add("0323-3499", "Mhartin Jhamal Tolentino", "BSCS - 1A", "Where Wizards Stay Up Late: The Origins of the Internet", "08/01/2024 00:00:00 am", "N/A", "Borrowed");
            // Database._Instance.DatabaseOfTransaction.Rows.Add(addStudentNo, addName, addCourse, addYear, addSection, addBookBorrowed, addBorrowedDate,addReturnedDate,addStatus);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(btnNew.Text == "NEW")
            {
                Add_Transaction add_Transaction = new Add_Transaction();
                add_Transaction.Show();
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    DataRow row = ((DataRowView)selectedRow.DataBoundItem).Row;

                    row["Student No."] = updateTransaction1.txtbox_StudentNo.Text;
                    row["Name"] = updateTransaction1.txtbox_Name.Text;
                    row["Course / Year / Section"] = updateTransaction1.txtbox_CYS.Text;
                    row["Book Borrowed"] = updateTransaction1.txtbox_BooksBorrowed.Text;
                    row["Borrowed Date"] = updateTransaction1.dateTimePicker1.Value;
                    row["Returned Date"] = updateTransaction1.dateTimePicker2.Value;
                    row["Status"] = updateTransaction1.comboBox_Status.SelectedItem;

                    MessageBox.Show("You successfully updated a book.");
                }

                updateTransaction1.Visible = false;
                lblTitle.Text = "Search";
                lblTitle.Location = new Point(78, 13);
                btnChangeUpdate.Text = "UPDATE";
                btnNew.Text = "NEW";
                btnDelete.Text = "DELETE";
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "DELETE")
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                MessageBox.Show("You successfully removed a book.");
            }
            else
            {
                return;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            checkRadioButtonChecked();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            defaultCheckedRadioButton();
        }

        private void checkRadioButtonChecked()
        {
            bool whatisit;
            string columnName = "";

            if (rdBtnAscending.Checked)
            {
                whatisit = true;
            }
            else
            {
                whatisit = false;
            }

            if (rdBtnStudentNo.Checked)
            {
                columnName = "Student No.";
            }
            else if (rdBtnName.Checked)
            {
                columnName = "Name";
            }
            else if (rdBtnCYS.Checked)
            {
                columnName = "Course / Year / Section";
            }
            else if (rdBtnName.Checked)
            {
                columnName = "Book Borrowed";
            }
            else if (rdBtnBook.Checked)
            {
                columnName = "Borrowed Date";
            }
            else if (rdBtnDateBorrowed.Checked)
            {
                columnName = "Returned Date";
            }
            else if (rdBtnDateReturned.Checked)
            {
                columnName = "Status";
            }

            SortColumn(columnName, whatisit);
        }

        private void SortColumn(string columnName, bool ascordsc)
        {
            dataGridView1.Sort(dataGridView1.Columns[columnName], ascordsc ? ListSortDirection.Ascending : ListSortDirection.Descending);
        }

        private void defaultCheckedRadioButton()
        {
            RadioButton rdbtn = rdBtnStudentNo;
            rdbtn.Checked = true;

            rdbtn = rdBtnAscending;
            rdbtn.Checked = true;

            SortColumn("Student No.", true);
        }

        private void btnChangeUpdate_Click(object sender, EventArgs e)
        {
            if (btnChangeUpdate.Text == "UPDATE")
            {
                //update1.Visible = true;
                updateTransaction1.Visible = true;
                lblTitle.Text = "Update";
                lblTitle.Location = new Point(75, 13);
                btnChangeUpdate.Text = "CANCEL";
                btnNew.Text = "UPDATE";
                btnDelete.Text = "";
            }
            else
            {
                //update1.Visible = false;
                updateTransaction1.Visible = false;
                lblTitle.Text = "Search";
                lblTitle.Location = new Point(78, 13);
                btnChangeUpdate.Text = "UPDATE";
                btnNew.Text = "NEW";
                btnDelete.Text = "DELETE";
                //dataGridView1.Enabled = true;
            }
        }

        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            updateTransaction1.txtbox_StudentNo.Text = selectedRow.Cells[0].Value.ToString();
            updateTransaction1.txtbox_Name.Text = selectedRow.Cells[1].Value.ToString();
            updateTransaction1.txtbox_CYS.Text = selectedRow.Cells[2].Value.ToString();
            updateTransaction1.txtbox_BooksBorrowed.Text = selectedRow.Cells[3].Value.ToString();

            if (selectedRow.Cells[6].Value != null)
            {
                if (selectedRow.Cells[6].Value.ToString() == "Borrowed")
                {
                    updateTransaction1.comboBox_Status.SelectedItem = "Borrowed";
                }
                else
                {
                    updateTransaction1.comboBox_Status.SelectedItem = "Returned";
                }
            }
            else
            {
                return;
            }

            string cellValue = selectedRow.Cells[4].Value.ToString();
            char[] characters = { 'N', 'A', '/' };

            if (characters.Any(c => cellValue.Contains(c)))
            {
                if (DateTime.TryParse(cellValue, out DateTime parsedDate))
                { 
                    updateTransaction1.dateTimePicker1.Value = parsedDate;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (DateTime.TryParse(selectedRow.Cells[4].FormattedValue.ToString(), out DateTime formattedDate))
                {
                    updateTransaction1.dateTimePicker1.Value = formattedDate;
                }
                else
                {
                    return;
                }
            }

            cellValue = selectedRow.Cells[5].Value.ToString();
            if (characters.Any(c => cellValue.Contains(c)))
            {
                if (DateTime.TryParse(cellValue, out DateTime parsedDate))
                {
                    updateTransaction1.dateTimePicker2.Value = parsedDate;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (DateTime.TryParse(selectedRow.Cells[5].FormattedValue.ToString(), out DateTime formattedDate))
                {
                    updateTransaction1.dateTimePicker2.Value = formattedDate;
                }
                else
                {
                    return;
                }
            }


            
        }
    }
}
