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
    public partial class StudentForm : Form
    {
        private Services.StudentService students = new Services.StudentService();


        public StudentForm()
        {
            InitializeComponent();
            grdStudent.MouseClick += GrdStudent_MouseClick;
            LoadData();
        }

        private void GrdStudent_MouseClick(object sender, MouseEventArgs e)
        {
            var rows = grdStudent.SelectedRows;
            if (rows==null || rows.Count==0)
            {
                lblStudentId.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                dateTimeDOB.Value = DateTime.Now;
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                return;
            }

            var rowData = rows[0];
            
            lblStudentId.Text = rowData.Cells[0].Value.ToString();
            txtName.Text = rowData.Cells[1].Value.ToString();
            txtEmail.Text = rowData.Cells[2].Value?.ToString();
            dateTimeDOB.Value = rowData.Cells[3].Value==null?DateTime.Now: Convert.ToDateTime(rowData.Cells[3].Value);

            btnCreate.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
           
        }

        private void LoadData()
        {
            grdStudent.DataSource = students.GetAll();
            grdStudent.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
            }
            else
            {
                var model = new DbFirst.Student() { Student1=txtName.Text, Email=txtEmail.Text, DOB=dateTimeDOB.Value };
                var res = students.Create(model);
                if (res)
                {
                    MessageBox.Show("Record inserted");
                    LoadData();
                    txtName.Text = "";
                    txtEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Some error occured");
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
            }
            else
            {
                var model = new DbFirst.Student() { Student1 = txtName.Text, Id=Convert.ToInt32(lblStudentId.Text), Email=txtEmail.Text, DOB=dateTimeDOB.Value };
                var res = students.Update(model);
                if (res)
                {
                    MessageBox.Show("Record updated");
                    LoadData();
                    txtName.Text = "";
                    lblStudentId.Text = "";
                    txtEmail.Text = "";
                    dateTimeDOB.Value = DateTime.Now;
                    btnCreate.Visible = true;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    MessageBox.Show("Some error occured");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var result = students.Delete(Convert.ToInt32(lblStudentId.Text));
                if (result)
                {
                    MessageBox.Show("Record deleted");
                    LoadData();
                    txtName.Text = "";
                    lblStudentId.Text = "";
                    txtEmail.Text = "";
                    dateTimeDOB.Value = DateTime.Now;
                    btnCreate.Visible = true;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    MessageBox.Show("Some error occured");
                }
            }
        }
    }
}
