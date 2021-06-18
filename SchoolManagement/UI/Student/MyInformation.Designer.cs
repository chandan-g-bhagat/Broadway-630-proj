
namespace SchoolManagement.UI.Student
{
    partial class MyInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassTeacher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSubjects = new System.Windows.Forms.DataGridView();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(152, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(152, 57);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(173, 22);
            this.txtClass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            // 
            // txtClassTeacher
            // 
            this.txtClassTeacher.Enabled = false;
            this.txtClassTeacher.Location = new System.Drawing.Point(152, 104);
            this.txtClassTeacher.Name = "txtClassTeacher";
            this.txtClassTeacher.Size = new System.Drawing.Size(173, 22);
            this.txtClassTeacher.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class Teacher";
            // 
            // grdSubjects
            // 
            this.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubjects.Location = new System.Drawing.Point(48, 246);
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.RowHeadersWidth = 51;
            this.grdSubjects.RowTemplate.Height = 24;
            this.grdSubjects.Size = new System.Drawing.Size(476, 178);
            this.grdSubjects.TabIndex = 7;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(152, 148);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(173, 22);
            this.txtRoomNumber.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room Number";
            // 
            // MyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdSubjects);
            this.Controls.Add(this.txtClassTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "MyInformation";
            this.Text = "MyInformation";
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdSubjects;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label4;
    }
}