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
            frmLogin newobj = new frmLogin();
            newobj.Show();
        }
    }
}
