using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SchoolManagement.ViewModel;
using SchoolManagement.UI.Admin;
using SchoolManagement.UI.Student;
using SchoolManagement.UI.Teacher;

namespace SchoolManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(Const.Basic.Login, ConfigurationManager.AppSettings[Const.Appsettings.AppName].ToString());

#if DEBUG

#endif
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("password is required");
                return;
            }

            var loginrequest = new LoginRequestViewModel()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            var result = Services.UserService.Login(loginrequest);
            if (result.Status)
            {
                switch (result.Type)
                {
                    case Common.UserType.Student:
                        StudentDashboard student = new StudentDashboard(result);
                        student.Show();
                        break;

                    case Common.UserType.Teacher:
                        TeacherDashboard teacher = new TeacherDashboard(result);
                        teacher.Show();
                        break;

                    case Common.UserType.Parent:
                        break;

                    case Common.UserType.Admin:

                        AdminDashboard admin = new AdminDashboard(result);
                        admin.Show();
                        break;

                    default:
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;
           if (e.KeyChar == 13)
            {
                Login();
            }
            else if (e.KeyChar == 27)
            {
                txtPassword.Text = string.Empty;
            }
        }
    }
}