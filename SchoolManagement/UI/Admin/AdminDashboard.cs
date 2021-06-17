using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.ViewModel;

namespace SchoolManagement.UI.Admin
{
    public partial class AdminDashboard : Form
    {
        private LoginResponseViewModel loginModel { get; set; }

        public AdminDashboard(LoginResponseViewModel model)
        {
            this.loginModel = model;
            InitializeComponent();
            this.Text = "Welcome " + loginModel.UserName;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCreateForm sc = new StudentCreateForm();
            sc.MdiParent = this;
            sc.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherForms tf = new TeacherForms();
            tf.MdiParent = this;
            tf.Show();
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm();
            cf.MdiParent = this;
            cf.Show();
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SubjectForm sf = new SubjectForm();
            sf.MdiParent = this;
            sf.Show();
        }

        private void assignStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAssignForm sf = new StudentAssignForm();
            sf.MdiParent = this;
            sf.Show();
        }
    }
}