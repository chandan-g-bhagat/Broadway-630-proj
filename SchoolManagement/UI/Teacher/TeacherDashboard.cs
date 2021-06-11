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

namespace SchoolManagement.UI.Teacher
{
    public partial class TeacherDashboard : Form
    {
        private LoginResponseViewModel loginModel { get; set; }
        public TeacherDashboard(LoginResponseViewModel model)
        {
            this.loginModel = model;
            InitializeComponent();
            label1.Text = "Welcome " + loginModel.UserName;
        }
    }
}
