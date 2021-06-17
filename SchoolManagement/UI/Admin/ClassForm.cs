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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
            LoadComboBox();
            LoadDta();
            cmbTeacher.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            dataGridView1.MouseClick += DataGridView1_MouseClick;
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var classId = Guid.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var students = StudentService.GetStudentsByClassId(classId);
                dataGridView2.DataSource = students;
                dataGridView2.Refresh();
            }
        }

        private void LoadDta()
        {
            dataGridView1.DataSource = ClassService.GetAllClasses();
            dataGridView1.Refresh();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)cmbTeacher.SelectedItem).Value;
            string Key = ((KeyValuePair<string, string>)cmbTeacher.SelectedItem).Key;
            MessageBox.Show(value + " " + Key);
        }

        private void LoadComboBox()
        {
            var teacherList = TeacherService.GetAllUnAssignedTeachers();

            if (teacherList.Count != 0)
            {
                cmbTeacher.DataSource = new BindingSource(teacherList, null);
                cmbTeacher.DisplayMember = "Value";
                cmbTeacher.ValueMember = "Key";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Key = ((KeyValuePair<string, string>)cmbTeacher.SelectedItem).Key;
            var classmodel = new ClassCreateViewModel()
            {
                Name = txtName.Text,
                RoomNumber = txtRoom.Text,
                Teacherid = Guid.Parse(Key)
            };
            var result = ClassService.CreateClass(classmodel);
            MessageBox.Show(result.Message);
        }
    }
}