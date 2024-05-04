using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //dataGridView1.DataSource = tableOfBooks;
    }
}
