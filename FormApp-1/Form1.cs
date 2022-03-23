using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_1
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        string name;
        string designation;
        int salary;
        string gender;
        string review;
        string nameCourse;

        public Form1()
        {
            InitializeComponent();
        }

        // Buton handle click save
        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello work!!!");
            name = textName.Text;
            designation = textDesignation.Text;
            salary = int.Parse(textSalary.Text);

            if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            review = chkGood.Checked ? "Good" : "Very Good";

            display();
            empty();
        }

        // Function render item in table
        public void display()
        {
            data.Columns.Add("Name");
            data.Columns.Add("Designation ");
            data.Columns.Add("Salary");
            data.Columns.Add("Gender");
            data.Columns.Add("Review");
            data.Columns.Add("Course");

            DataRow dr= data.NewRow();
            dr[0] = name;
            dr[1] = designation;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = review;
            dr[5] = nameCourse;

            data.Rows.Add(dr);
            dtDataGridView.DataSource = data;
        }

        // Funtion reset to empty
        public void empty()
        {
            textName.Text = "";
            textDesignation.Text = "";
            textSalary.Text = "";
        }

        // Add item to comboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.Add("C# Programming");
            cmbCourse.Items.Add("PHP Programming");
            cmbCourse.Items.Add("Java Programming");
            cmbCourse.Items.Add("Ruby Programming");
        }

        // Select item get value
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCourse = cmbCourse.SelectedItem.ToString();
            //MessageBox.Show(nameCourse);
        }
    }
}
