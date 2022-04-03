namespace freetut_c_shrap
{
    partial class Crud_Students
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
            this.lbl_first_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_first_number
            // 
            this.lbl_first_number.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_number.ForeColor = System.Drawing.Color.Blue;
            this.lbl_first_number.Location = new System.Drawing.Point(12, 9);
            this.lbl_first_number.Name = "lbl_first_number";
            this.lbl_first_number.Size = new System.Drawing.Size(1009, 51);
            this.lbl_first_number.TabIndex = 2;
            this.lbl_first_number.Text = "Crud Students ";
            this.lbl_first_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crud_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.lbl_first_number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crud_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud_Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_first_number;
    }
}