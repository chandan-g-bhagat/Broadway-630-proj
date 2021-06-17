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
            cmbTeacher.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
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