using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedAcees_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            table.TableName = "Username";

            DataColumn col1 = new DataColumn();
            col1.ColumnName = "id";
            col1.DataType = Type.GetType("System.Int32");

            DataColumn col2 = new DataColumn();
            col2.ColumnName = "username";
            col2.DataType = Type.GetType("System.String");

            DataColumn col3 = new DataColumn();
            col3.ColumnName = "password";
            col3.DataType = Type.GetType("System.String");


            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);

            DataRow row = table.NewRow();
            row["id"] = 1;
            row["username"] = "Nadir";
            row["password"] = "nadir123";

            DataRow row1 = table.NewRow();
            row1["id"] = 2;
            row1["username"] = "Zeeshan";
            row1["password"] = "Zii@m";

            table.Rows.Add(row);
            table.Rows.Add(row1);

            set.Tables.Add(table);

            this.dataGridView1.DataSource = set.Tables["Username"];
            
        }
    }
}
