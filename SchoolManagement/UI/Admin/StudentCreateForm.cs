using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Services;
using SchoolManagement.ViewModel;

namespace SchoolManagement.UI.Admin
{
    public partial class StudentCreateForm : Form
    {
        public StudentCreateForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.DataSource = UserService.GetAllStudents().ToList();
            dataGridView1.Refresh();
        }

        void ResetTextFields()
        {
            txtAddress.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextFields();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool result = false;
            var message=ValidateFunction(ref result);

            if (result)
            {
                var studentUser = new StudentCreateViewModel() {
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Name = txtName.Text,
                    Password = txtPassword.Text,
                    Username = txtUsername.Text
                };
                var studentCreateResult = UserService.CreateStudentUser(studentUser);
                if (studentCreateResult.Status)
                {
                    ResetTextFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(studentCreateResult.Message, "Error!");
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// Validates the input 
        /// </summary>
        /// <param name="result"></param>
        /// <returns>returns the message</returns>
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
                    message= string.Empty;
                }
                else
                {
                    result = false;
                    message = Const.Basic.WrongPasswordPrompt;
                }
            }

            return message;
        }
    }
}
