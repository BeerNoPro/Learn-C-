namespace freetut_c_shrap
{
    partial class FormIndex
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
            this.btn_show_calculate_form = new System.Windows.Forms.Button();
            this.lbl_first_number = new System.Windows.Forms.Label();
            this.Btn_Crud_Students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_show_calculate_form
            // 
            this.btn_show_calculate_form.Location = new System.Drawing.Point(34, 134);
            this.btn_show_calculate_form.Name = "btn_show_calculate_form";
            this.btn_show_calculate_form.Size = new System.Drawing.Size(162, 74);
            this.btn_show_calculate_form.TabIndex = 0;
            this.btn_show_calculate_form.Text = "CalculateForm";
            this.btn_show_calculate_form.UseVisualStyleBackColor = true;
            this.btn_show_calculate_form.Click += new System.EventHandler(this.btn_show_calculate_form_Click);
            // 
            // lbl_first_number
            // 
            this.lbl_first_number.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_number.ForeColor = System.Drawing.Color.Blue;
            this.lbl_first_number.Location = new System.Drawing.Point(0, -1);
            this.lbl_first_number.Name = "lbl_first_number";
            this.lbl_first_number.Size = new System.Drawing.Size(1035, 87);
            this.lbl_first_number.TabIndex = 1;
            this.lbl_first_number.Text = "Welcome to learn C#";
            this.lbl_first_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Crud_Students
            // 
            this.Btn_Crud_Students.Location = new System.Drawing.Point(296, 134);
            this.Btn_Crud_Students.Name = "Btn_Crud_Students";
            this.Btn_Crud_Students.Size = new System.Drawing.Size(162, 74);
            this.Btn_Crud_Students.TabIndex = 2;
            this.Btn_Crud_Students.Text = "Crud-Students";
            this.Btn_Crud_Students.UseVisualStyleBackColor = true;
            this.Btn_Crud_Students.Click += new System.EventHandler(this.Btn_Crud_Students_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.Btn_Crud_Students);
            this.Controls.Add(this.lbl_first_number);
            this.Controls.Add(this.btn_show_calculate_form);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreetutLearC#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_show_calculate_form;
        private System.Windows.Forms.Label lbl_first_number;
        private System.Windows.Forms.Button Btn_Crud_Students;
    }
}

