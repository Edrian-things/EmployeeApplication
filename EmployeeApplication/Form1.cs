//Edrian Badoy
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeNamespace;


namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {

        private List<Employee> employees = new List<Employee>();
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("EmPloyeeID", "Employee ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Postion", "Position");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeID = textBox1.Text,
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                Position = textBox4.Text
            };

            employees.Add(employee);
            dataGridView1.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName, employee.Position);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }
    }
}
