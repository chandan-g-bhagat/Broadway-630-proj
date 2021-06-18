using SchoolManagement.Models;
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

namespace SchoolManagement.UI.Student
{
    public partial class MyInformation : Form
    {
        private User me = new User();

        public MyInformation(User student)
        {
            me = student;
            InitializeComponent();
            loadinfo();
        }

        private void loadinfo()
        {
            var student = me.Student.FirstOrDefault();
            txtName.Text = student.Name;
            txtClass.Text = student.Classes.Name;
            txtClassTeacher.Text = student.Classes.ClassTeacher.Name;
            txtRoomNumber.Text = student.Classes.RoomNumber;

            var subjects = student.Classes.Subjects.Select(p => new StudentsubjectViewModel { Id = p.Id, Code = p.Code, Name = p.Name, Teacher = p.Teacher.Name }).ToList();

            grdSubjects.DataSource = subjects;
            grdSubjects.Refresh();
        }
    }
}