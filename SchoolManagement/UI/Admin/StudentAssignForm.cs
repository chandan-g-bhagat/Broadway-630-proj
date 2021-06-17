using SchoolManagement.Services;
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
    public partial class StudentAssignForm : Form
    {
        public StudentAssignForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var unassignedStudents = StudentService.GetAllUnAssignedStudents();
            lstStudent.DataSource = new BindingSource(unassignedStudents, null);
            lstStudent.DisplayMember = "Value";
            lstStudent.ValueMember = "Key";

            var classes = ClassService.GetAllClassDictionary();
            lstClass.DataSource = new BindingSource(classes, null);
            lstClass.DisplayMember = "Value";
            lstClass.ValueMember = "Key";

            dataGridView1.DataSource = StudentService.GetListofAssignedStudents();
            dataGridView1.Refresh();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var studentId = Guid.Parse(((KeyValuePair<string, string>)lstStudent.SelectedItem).Key);
            var classId = Guid.Parse(((KeyValuePair<string, string>)lstClass.SelectedItem).Key);

            var res = StudentService.AssignStudent(studentId, classId);
            MessageBox.Show(res.Message);

            LoadData();
        }
    }
}