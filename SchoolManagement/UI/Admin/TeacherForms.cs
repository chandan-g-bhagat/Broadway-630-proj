using SchoolManagement.Services;
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

namespace SchoolManagement.UI.Admin
{
    public partial class TeacherForms : Form
    {
        public TeacherForms()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool result = false;
            var message = ValidateFunction(ref result);

            if (result)
            {
                var teacherUser = new TeacherCreateViewModel()
                {
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Name = txtName.Text,
                    Password = txtPassword.Text,
                    Username = txtUsername.Text
                };
                var teacherCreateResult = UserService.CreateTeacherUser(teacherUser);
                if (teacherCreateResult.Status)
                {
                    ResetTextFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(teacherCreateResult.Message, "Error!");
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = UserService.GetAllTeachers().ToList();
            dataGridView1.Refresh();
        }

        private void ResetTextFields()
        {
            txtAddress.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private string ValidateFunction(ref bool result)
        {
            string message = "Some of the fields are required! Please check them!";
            if (
                !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtUsername.Text)
                )
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    result = true;
                    message = string.Empty;
                }
                else
                {
                    result = false;
                    message = Const.Basic.WrongPasswordPrompt;
                }
            }

            return message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextFields();
        }
    }
}