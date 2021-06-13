using SchoolManagement.Data;
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
        public StudentDashboard(LoginResponseViewModel model)
        {
            this.loginModel = model;
            InitializeComponent();
            var userDetails = db.Users.Find(loginModel.UserId);
            label1.Text = "Welcome " + loginModel.UserName;
        }
    }
}
