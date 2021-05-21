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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //this.btnSomething.Click += BtnSomething_Click;
            this.MouseDown += FrmLogin_MouseDown;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                
                contextMenuStrip1.Show( e.Location);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("The text field cannot be blank.");
            }
            else
            {
                double One = Convert.ToDouble(textBox1.Text);
                double Two = Convert.ToDouble(textBox2.Text);

                MessageBox.Show("The result is " + (One + Two).ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var res=colorDialog1.ShowDialog();
            //label3.Text = maskedTextBox1.Text;
            openFileDialog1.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadGridData();
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                Task.Delay(100);
                toolStripProgressBar1.Value = i;
            }
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }
        void LoadGridData()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FName = "Niroj", LName = "Gansi" });
            students.Add(new Student { FName = "Niroj", LName = "Gansi" });
            students.Add(new Student { FName = "Niroj", LName = "Gansi" });
            students.Add(new Student { FName = "Niroj", LName = "Gansi" });
            students.Add(new Student { FName = "Niroj", LName = "Gansi" });




            dataGridView1.DataSource = students;
            dataGridView1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // webBrowser1.Url = new Uri(textBox3.Text);
            webBrowser1.Navigate(new Uri(textBox3.Text));

        }
    }

    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
