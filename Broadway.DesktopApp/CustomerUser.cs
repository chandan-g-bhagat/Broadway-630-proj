using Broadway.DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.DesktopApp
{
    public partial class CustomerUser : Form
    {
        private Services.CustomerUserService customerUser = new Services.CustomerUserService();
        public CustomerUser()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo validation ko code afaile lekhne
            var model = new CustomerUserModel() {
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Name = txtName.Text,
                Password = txtPassword.Text,
                Phone = txtPhone.Text,
                UserName = txtUserName.Text
            };
            var res = customerUser.Insert(model);
            if (res)
            {
                MessageBox.Show("Records added");
                LoadData();
                CLearAll();
            }
            else
            {
                MessageBox.Show("Some error occured");
            }
        }
        void CLearAll()
        {
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
        }

        void LoadData()
        {
            //grdCustomer.DataSource = customerUser.GetAllCustomers();
            //grdCustomer.Refresh();

            //grdUser.DataSource = customerUser.GetAllUsers();
            //grdUser.Refresh();

            grdCustomerUser.DataSource = customerUser.GetAllCustomerUser();
            grdCustomerUser.Refresh();
        }
    }
}
