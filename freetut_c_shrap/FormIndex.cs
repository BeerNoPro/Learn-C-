using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freetut_c_shrap
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void btn_show_calculate_form_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello guy");
            var calculateForm = new CalculateForm();
            calculateForm.Show();
        }

        private void Btn_Crud_Students_Click(object sender, EventArgs e)
        {
            Crud_Students curdStudents = new Crud_Students();
            curdStudents.Show();
        }
    }
}
