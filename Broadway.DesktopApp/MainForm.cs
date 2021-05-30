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

namespace Broadway.DesktopApp
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BW_630;Integrated Security=True;";
        public MainForm()
        {
            InitializeComponent();

            LoadData();
        }



        void LoadData()
        {
            List<string> strs = new List<string>();
            List<Students> studentList = new List<Students>();

           

            //create object of sqlconnection
            var connection = new SqlConnection(connectionString);
            
            var query = "select Id,Student from Student";

            var command = new SqlCommand(query, connection);

            connection.Open();
            try
            {
                var res = command.ExecuteReader();
                while (res.Read())
                {
                    strs.Add(res.GetValue(0).ToString());

                    var st = new Students();
                    st.Id = res.GetFieldValue<int>(0);
                    st.Name = res.GetFieldValue<string>(1);
                    studentList.Add(st);
                    //label1.Text += "\n"+res.GetValue(1);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            connection.Close();

            comboBox1.DataSource = strs;
            comboBox1.Refresh();

            dataGridView1.DataSource = studentList;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Insert();
            }
        }

        void Insert()
        {
            //create object of sqlconnection
            var connection = new SqlConnection(connectionString);

            var query = $"insert into student (Student) values ('{textBox1.Text}')";

            var command = new SqlCommand(query, connection);

            connection.Open();
            try
            {
                var res = command.ExecuteNonQuery();
                if (res>0)
                {
                    MessageBox.Show("Record Added successfully");
                    textBox1.Text = "";
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Unable to add");
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }

            connection.Close();
        }
    }

    public class Students //model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
