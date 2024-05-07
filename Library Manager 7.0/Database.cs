using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    internal class Database
    {
        // One-time instantiation
        /* <======================================> */
        private static Database _instance;
        private Database() { }
        public static Database _Instance
        {
            get 
            { 
                if(_instance == null)
                {
                    _instance = new Database();
                }
                return _instance;
            }
        }
        /* <======================================> */

        private DataTable databaseOfBooks = new DataTable("Books");
        private DataTable databaseOfTransaction = new DataTable("Transactions");

        

        public DataTable DatabaseOfBooks
        {
            get { return databaseOfBooks; }
            set { databaseOfBooks = value; }
        }

        public DataTable DatabaseOfTransaction
        {  
            get { return databaseOfTransaction; } 
            set { databaseOfTransaction = value; }
        }

        public void ColumnsForDataGrideView1()
        {
            // 0 | Dewey Decimal System
            Database._Instance.DatabaseOfBooks.Columns.Add("Dewey Decimal System", Type.GetType("System.String"));

            // 1 | Title
            Database._Instance.DatabaseOfBooks.Columns.Add("Title", Type.GetType("System.String"));

            // 2 | Author
            Database._Instance.DatabaseOfBooks.Columns.Add("Author", Type.GetType("System.String"));

            // 3 | Category
            Database._Instance.DatabaseOfBooks.Columns.Add("Category", Type.GetType("System.String"));

            // 4 | Year of Publication
            Database._Instance.DatabaseOfBooks.Columns.Add("Year of Publication", Type.GetType("System.String"));

            // 5 | Date Added
            Database._Instance.DatabaseOfBooks.Columns.Add("Date Added", Type.GetType("System.String"));

            // 6 | Availability
            Database._Instance.DatabaseOfBooks.Columns.Add("Availability", Type.GetType("System.String"));
        }

        public void ColumnsForDatabaseOfTranasction()
        {
            Database._instance.databaseOfTransaction.Columns.Add("Student No.", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Name", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Course / Year / Section", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Book Borrowed", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Borrowed Date", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Returned Date", Type.GetType("System.String"));
            Database._instance.databaseOfTransaction.Columns.Add("Status", Type.GetType("System.String"));
        }

        //dataGridView1.DataSource = tableOfBooks;
    }
}
