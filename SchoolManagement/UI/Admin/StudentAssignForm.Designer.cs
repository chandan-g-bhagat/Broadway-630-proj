
namespace SchoolManagement.UI.Admin
{
    partial class StudentAssignForm
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
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.ItemHeight = 16;
            this.lstStudent.Location = new System.Drawing.Point(12, 12);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(174, 228);
            this.lstStudent.TabIndex = 0;
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Location = new System.Drawing.Point(12, 246);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(174, 228);
            this.lstClass.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(192, 210);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(133, 59);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 477);
            this.dataGridView1.TabIndex = 3;
            // 
            // StudentAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.lstStudent);
            this.Name = "StudentAssignForm";
            this.Text = "StudentAssignForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}