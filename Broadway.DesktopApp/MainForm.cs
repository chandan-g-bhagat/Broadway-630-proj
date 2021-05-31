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
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BW_630;Integrated Security=True;";
        public MainForm()
        {
            InitializeComponent();

            //LoadData();
            InitialLoad();
        }

        void InitialLoad()
        {
            StudentModel s1 = new StudentModel();
            s1.GetAll();
            dataGridView1.DataSource = s1.Table;
            dataGridView1.Refresh();

            ParentModel p1 = new ParentModel();
            p1.GetAll();
            dataGridView2.DataSource = p1.Table;
            dataGridView2.Refresh();

            MenuModel m1 = new MenuModel();
            m1.GetAll();
            dataGridView3.DataSource = m1.Table;
            dataGridView3.Refresh();
        }



       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                StudentModel s1 = new StudentModel();
                s1.Name = textBox1.Text;
                s1.Insert();

                InitialLoad();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                ParentModel p1 = new ParentModel();
                p1.Name = textBox2.Text;
                p1.Type = comboBox2.SelectedIndex;
                p1.Insert();

                InitialLoad();
            }
        }
    }

    public class Students //model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
