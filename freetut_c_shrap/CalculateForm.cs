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
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {
            //txt_first_number.Text = "Your enter first number...";
        }

        #region check input number
        private void txt_first_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Handle when click button summation
        private void btn_summation_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txt_first_number.Text);
            int secondNumber = Convert.ToInt32(txt_second_number.Text);
            int result = firstNumber + secondNumber;
            txt_result.Text = result.ToString();
        }
        #endregion

        #region Handle when button subtraction
        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txt_first_number.Text);
            int secondNumber = Convert.ToInt32(txt_second_number.Text);
            int result = firstNumber - secondNumber;
            txt_result.Text = result.ToString();
        }
        #endregion

        #region Handle when click button multiplication
        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txt_first_number.Text);
            int secondNumber = Convert.ToInt32(txt_second_number.Text);
            int result = firstNumber * secondNumber;
            txt_result.Text = result.ToString();
        }
        #endregion

        #region Handle when click button division
        private void btn_division_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txt_first_number.Text);
            int secondNumber = Convert.ToInt32(txt_second_number.Text);
            int result = firstNumber / secondNumber;
            txt_result.Text = result.ToString();
        }
        #endregion

        #region Handle click button del
        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_first_number.Clear();
            txt_second_number.Clear();
            txt_result.Clear();
        }
        #endregion

    }
}
