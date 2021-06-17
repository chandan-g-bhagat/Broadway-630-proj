
namespace SchoolManagement.UI.Admin
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignClassTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.examsToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.classesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // examsToolStripMenuItem
            // 
            this.examsToolStripMenuItem.Name = "examsToolStripMenuItem";
            this.examsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.examsToolStripMenuItem.Text = "Exams";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.manageToolStripMenuItem});
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem2.Text = "Create";
            this.createToolStripMenuItem2.Click += new System.EventHandler(this.createToolStripMenuItem2_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignTeacherToolStripMenuItem,
            this.assignClassToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // assignTeacherToolStripMenuItem
            // 
            this.assignTeacherToolStripMenuItem.Name = "assignTeacherToolStripMenuItem";
            this.assignTeacherToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.assignTeacherToolStripMenuItem.Text = "Assign Teacher";
            // 
            // assignClassToolStripMenuItem
            // 
            this.assignClassToolStripMenuItem.Name = "assignClassToolStripMenuItem";
            this.assignClassToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.assignClassToolStripMenuItem.Text = "Assign Class";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem3,
            this.manageToolStripMenuItem1});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.classesToolStripMenuItem.Text = "Class";
            // 
            // createToolStripMenuItem3
            // 
            this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            this.createToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem3.Text = "Create";
            this.createToolStripMenuItem3.Click += new System.EventHandler(this.createToolStripMenuItem3_Click);
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignStudentsToolStripMenuItem,
            this.assignClassTeacherToolStripMenuItem});
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.manageToolStripMenuItem1.Text = "Manage";
            // 
            // assignStudentsToolStripMenuItem
            // 
            this.assignStudentsToolStripMenuItem.Name = "assignStudentsToolStripMenuItem";
            this.assignStudentsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.assignStudentsToolStripMenuItem.Text = "Assign Students";
            this.assignStudentsToolStripMenuItem.Click += new System.EventHandler(this.assignStudentsToolStripMenuItem_Click);
            // 
            // assignClassTeacherToolStripMenuItem
            // 
            this.assignClassTeacherToolStripMenuItem.Name = "assignClassTeacherToolStripMenuItem";
            this.assignClassTeacherToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.assignClassTeacherToolStripMenuItem.Text = "Assign Class Teacher";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assignStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignClassTeacherToolStripMenuItem;
    }
}