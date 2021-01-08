using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Linq;

namespace Student_Databse_App
{
    public partial class Form1 : Form
    {
        static String connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PopulateListBox();

        }
        public void PopulateListBox()
        {
            //include linq library as : using System.Linq;
            LinqToSqlDataContext context = new LinqToSqlDataContext();

            var query = from student in context.Student_Tables select student;

            foreach (var student in query)
            {

                this.studentList.Items.Add(student);
                //ToString() overriden in Student_Table class, or we may also write
                //this.studentList.Items.Add(student.FirstName) but we have to show 
                //all data related to object in listBox;
            }
        }
    private void addButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {

                Student_Table student = new Student_Table();
                student.FirstName = this.firstName.Text;
                student.LastName = this.lastName.Text;
                student.City = this.city.Text;
                student.State = this.state.Text;
                student.Nationality = this.nationality.Text;

                context.Student_Tables.InsertOnSubmit(student);
                context.SubmitChanges();
                MessageBox.Show("Record Added");
                this.studentList.Items.Clear();
                PopulateListBox();
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {

                Student_Table student = context.Student_Tables.SingleOrDefault(StudentName => StudentName.FirstName == this.studentList.SelectedItem.ToString());

                student.LastName = this.lastName.Text;
                student.City = this.city.Text;
                student.State = this.state.Text;
                student.Nationality = this.nationality.Text;

                context.SubmitChanges();
                MessageBox.Show("Record Updated");
                this.studentList.Items.Clear();
                PopulateListBox();
            };
        }
   
        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext()) {

                Student_Table student = context.Student_Tables.SingleOrDefault(StudentName => StudentName.FirstName==this.studentList.SelectedItem.ToString());

                context.Student_Tables.DeleteOnSubmit(student);

                context.SubmitChanges();
                MessageBox.Show("Record Deleted");
                this.studentList.Items.Clear();
                PopulateListBox();
                ClearFileds();
            } ;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFileds();
        }
        public void ClearFileds() {

            firstName.Clear();
            lastName.Clear();
            state.Clear();
            nationality.Clear();
            city.Clear();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            printData();
        }
        public void printData() {
            
            LinqToSqlDataContext context = new LinqToSqlDataContext();
            var v = from student in context.Student_Tables where student.FirstName == this.studentList.SelectedItem.ToString() select student;

            foreach (var student in v)
            {

                this.firstName.Text = student.FirstName;
                this.lastName.Text = student.LastName;
                this.city.Text = student.City;
                this.state.Text = student.State;
                this.nationality.Text = student.Nationality;
            }
        }

    }
}
