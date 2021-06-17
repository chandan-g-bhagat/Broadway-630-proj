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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var classid = Guid.Parse(((KeyValuePair<string, string>)cmbClass.SelectedItem).Key);
            var teacherId = Guid.Parse(((KeyValuePair<string, string>)cmbTeacher.SelectedItem).Key);

            var subjectCreateVM = new SubjectCreateViewModel()
            {
                Name = txtName.Text,
                Code = txtCode.Text,
                ClassId = classid,
                TeacherId = teacherId
            };

            var res = SubjectService.CreateSubjects(subjectCreateVM);
            MessageBox.Show(res.Message);
            LoadData();
            ResetTextFields();
        }

        private void LoadComboBox()
        {
            var teacherList = TeacherService.GetAllTeachersDictionary();

            if (teacherList.Count != 0)
            {
                cmbTeacher.DataSource = new BindingSource(teacherList, null);
                cmbTeacher.DisplayMember = "Value";
                cmbTeacher.ValueMember = "Key";
            }

            var classList = ClassService.GetAllClassDictionary();

            if (classList.Count != 0)
            {
                cmbClass.DataSource = new BindingSource(classList, null);
                cmbClass.DisplayMember = "Value";
                cmbClass.ValueMember = "Key";
            }
        }

        private void LoadData()
        {
            grdSubject.DataSource = SubjectService.GetAllSubjects();
            grdSubject.Refresh();
        }

        private void ResetTextFields()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            cmbClass.SelectedItem = null;
            cmbTeacher.SelectedItem = null;
        }
    }
}