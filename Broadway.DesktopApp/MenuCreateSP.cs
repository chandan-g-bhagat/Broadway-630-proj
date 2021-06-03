using Broadway.DesktopApp.Data;
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
    public partial class MenuCreateSP : Form
    {
        public MenuCreateSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMenuName.Text))
            {
                int? id = null; //Nullable type of int 
                

                if (!string.IsNullOrWhiteSpace(txtParentId.Text))
                {
                    id = Convert.ToInt32(txtParentId.Text);
                }
                var dataset=StoredProcedureCalls.CreateMenu(txtMenuName.Text, id);


                if (dataset!=null)
                {
                    dataGridView1.DataSource = dataset.Tables[0];
                    dataGridView2.DataSource = dataset.Tables[1];
                    dataGridView3.DataSource = dataset.Tables[2];

                    dataGridView1.Refresh();
                    dataGridView2.Refresh();
                    dataGridView3.Refresh();
                }

            }
            else
            {
                MessageBox.Show("Menu Name is Empty");
            }
        }
    }
}
