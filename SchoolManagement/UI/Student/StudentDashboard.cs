using SchoolManagement.Data;
using SchoolManagement.Models;
using SchoolManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.UI.Student
{
    public partial class StudentDashboard : Form
    {
        private LoginResponseViewModel loginModel { get; set; }

        private DefaultContext db = new DefaultContext();
        private User user;

        public StudentDashboard(LoginResponseViewModel model)
        {
            this.loginModel = model;
            InitializeComponent();
            user = db.Users.Find(loginModel.UserId);

            MyInformation mf = new MyInformation(user);
            mf.MdiParent = this;
            mf.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(user);
            cp.MdiParent = this;
            cp.Show();
        }
    }
}