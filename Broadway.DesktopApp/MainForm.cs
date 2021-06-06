using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broadway.DesktopApp.Data;

namespace Broadway.DesktopApp
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            //student load and display
            Student_Model s1 = new Student_Model();
            s1.GetAll();

            grdStudent.DataSource = s1.Table;
            grdStudent.Refresh();

            //Parent load and display
            Parent_Model p1 = new Parent_Model();
            p1.GetAll();

            grdParent.DataSource = p1.Table;
            grdParent.Refresh();
            //Menu load and display
            Menu_Model m1 = new Menu_Model();
            m1.GetAll();

            grdMenu.DataSource = m1.Table;
            grdMenu.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Student_Model s1 = new Student_Model();
                s1.Name = textBox1.Text;
                s1.Create();

                textBox1.Text = "";
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Parent Name is required");
                return;
            }
            
            if (comboBox2.SelectedItem==null)
            {
                MessageBox.Show("Parent type is required");
                return;
            }
                        
            Parent_Model p1 = new Parent_Model();
            p1.Name = textBox2.Text;
            p1.Type = comboBox2.SelectedItem.ToString() == "Father" ? 0 : 1;
            p1.Create();
            textBox2.Text = "";
            comboBox2.SelectedItem = null;

            LoadData();
            
        }

        private void grdStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void grdStudent_Click(object sender, EventArgs e)
        {
            var grid = (DataGridView)sender;
            var selectedRows = grid.SelectedRows;

            if (selectedRows != null && selectedRows.Count==1)
            {
                lblStudentId.Text = selectedRows[0].Cells["Id"].Value.ToString();
                textBox1.Text = selectedRows[0].Cells["Student"].Value.ToString();

                btn_Update.Visible = true;
                btn_delete.Visible = true;
                btn_Create.Visible = false;
            }
            else
            {
                lblStudentId.Text = "";
                textBox1.Text = "";
                btn_Update.Visible = false;
                btn_delete.Visible = false;
                btn_Create.Visible = true;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Student_Model s1 = new Student_Model();
                s1.Id = Convert.ToInt32(lblStudentId.Text);
                s1.Name = textBox1.Text;
                s1.Update();

                textBox1.Text = "";
                lblStudentId.Text = "";
                LoadData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblStudentId.Text))
            {
                Student_Model s1 = new Student_Model();
                s1.Id = Convert.ToInt32(lblStudentId.Text);
               
                s1.Delete();

                textBox1.Text = "";
                lblStudentId.Text = "";
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuCreateSP sp = new MenuCreateSP();
            //sp.Show();
        }
    }
   
}
