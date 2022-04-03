namespace freetut_c_shrap
{
    partial class CalculateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_second_number = new System.Windows.Forms.Label();
            this.lbl_first_number = new System.Windows.Forms.Label();
            this.txt_first_number = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_summation = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_second_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_second_number
            // 
            this.lbl_second_number.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_second_number.Location = new System.Drawing.Point(123, 164);
            this.lbl_second_number.Name = "lbl_second_number";
            this.lbl_second_number.Size = new System.Drawing.Size(191, 55);
            this.lbl_second_number.TabIndex = 2;
            this.lbl_second_number.Text = "Second number:";
            this.lbl_second_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_first_number
            // 
            this.lbl_first_number.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_number.Location = new System.Drawing.Point(123, 61);
            this.lbl_first_number.Name = "lbl_first_number";
            this.lbl_first_number.Size = new System.Drawing.Size(191, 55);
            this.lbl_first_number.TabIndex = 1;
            this.lbl_first_number.Text = "First number:";
            this.lbl_first_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_first_number
            // 
            this.txt_first_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_number.ForeColor = System.Drawing.Color.Black;
            this.txt_first_number.Location = new System.Drawing.Point(320, 72);
            this.txt_first_number.Multiline = true;
            this.txt_first_number.Name = "txt_first_number";
            this.txt_first_number.Size = new System.Drawing.Size(247, 31);
            this.txt_first_number.TabIndex = 1;
            this.txt_first_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_first_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_number_KeyPress);
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(113, 407);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(191, 55);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Result:";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(320, 418);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(247, 44);
            this.txt_result.TabIndex = 8;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_summation
            // 
            this.btn_summation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_summation.Location = new System.Drawing.Point(117, 283);
            this.btn_summation.Name = "btn_summation";
            this.btn_summation.Size = new System.Drawing.Size(54, 44);
            this.btn_summation.TabIndex = 3;
            this.btn_summation.Text = "+";
            this.btn_summation.UseVisualStyleBackColor = true;
            this.btn_summation.Click += new System.EventHandler(this.btn_summation_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtraction.Location = new System.Drawing.Point(215, 283);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(54, 44);
            this.btn_subtraction.TabIndex = 4;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplication.Location = new System.Drawing.Point(320, 283);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(54, 44);
            this.btn_multiplication.TabIndex = 5;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(414, 283);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(54, 44);
            this.btn_division.TabIndex = 6;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(513, 283);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(54, 44);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_second_number
            // 
            this.txt_second_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_second_number.ForeColor = System.Drawing.Color.Black;
            this.txt_second_number.Location = new System.Drawing.Point(320, 175);
            this.txt_second_number.Multiline = true;
            this.txt_second_number.Name = "txt_second_number";
            this.txt_second_number.Size = new System.Drawing.Size(247, 31);
            this.txt_second_number.TabIndex = 2;
            this.txt_second_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_second_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_number_KeyPress);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 537);
            this.Controls.Add(this.txt_second_number);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_summation);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.lbl_first_number);
            this.Controls.Add(this.txt_first_number);
            this.Controls.Add(this.lbl_second_number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculateForm";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_second_number;
        private System.Windows.Forms.Label lbl_first_number;
        private System.Windows.Forms.TextBox txt_first_number;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_summation;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_second_number;
    }
}