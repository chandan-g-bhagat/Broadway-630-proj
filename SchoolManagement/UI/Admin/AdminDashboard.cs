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
            label1.Text = "Welcome " + loginModel.UserName + " "+ loginModel.UserId;
        }
    }
}
