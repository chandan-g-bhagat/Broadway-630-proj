using SchoolManagement.Models;
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

namespace SchoolManagement.UI
{
    public partial class ChangePassword : Form
    {
        private User me;

        public ChangePassword(User user)
        {
            me = user;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTestFields();
        }

        private void resetTestFields()
        {
            txtOld.Text = string.Empty;
            txtNew.Text = string.Empty;
            txtConfirm.Text = string.Empty;
        }

        private void Change()
        {
            if (Valid())
            {
                var changeModel = new ChangePasswordViewModel()
                {
                    Id = me.Id,
                    NewPassword = txtNew.Text,
                    OldPassword = txtOld.Text
                };

                var result = UserService.ChangePassword(changeModel);
                MessageBox.Show(result.Message);
                resetTestFields();
            }
        }

        private bool Valid()
        {
            var result = false;

            if (!string.IsNullOrWhiteSpace(txtNew.Text) && !string.IsNullOrWhiteSpace(txtOld.Text) && !string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                if (txtNew.Text == txtConfirm.Text)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}