using Broadway.DesktopApp.Services;
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
    public partial class MenuForm : Form
    {
        private MenuService _menu = new MenuService();
        public MenuForm()
        {
            InitializeComponent();
            loadData();
            dataGridView1.MouseClick += DataGridView1_MouseClick;
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows == null || dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var data = dataGridView1.SelectedRows[0];
            if (data == null)
            {
                txtMenuName.Text = "";
                txtMenuUrl.Text = "";
                cmbParentMenu.SelectedItem = null;
                lblMenuId.Text = "";

                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                txtMenuName.Text = data.Cells[1].Value.ToString();
                txtMenuUrl.Text = data.Cells[2].Value?.ToString();
                cmbParentMenu.SelectedIndex = cmbParentMenu.FindString(data.Cells[3].Value?.ToString() + " : ");
                lblMenuId.Text = data.Cells[0].Value.ToString();

                btnCreate.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
        }

        void loadData()
        {
            var data = _menu.GetAll();
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
            //id : MenuName
            List<string> menu = new List<string>();
            menu.Add("");
            var menufromDB = (from d in data select $"{d.Id} : {d.MenuName}").ToList();
            menu.AddRange(menufromDB);

            cmbParentMenu.DataSource=menu;
            cmbParentMenu.Refresh();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new DbFirst.Menu();
            menu.MenuName = txtMenuName.Text;
            menu.MenuUrl = txtMenuUrl.Text;

            var selectedItem = cmbParentMenu.SelectedItem==null?"": cmbParentMenu.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(selectedItem))
            {
                var arr = selectedItem.Split(':');
                menu.ParentId = Convert.ToInt32(arr[0]);
            }
            else
            {
                menu.ParentId = null;
            }

            var res=_menu.Create(menu);
            if (res)
            {
                MessageBox.Show("Record Inserted");
                loadData();
                txtMenuName.Text = "";
                txtMenuUrl.Text = "";
            }
            else
            {
                MessageBox.Show("Some Error Occured");
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var menu = new DbFirst.Menu();
            menu.MenuName = txtMenuName.Text;
            menu.MenuUrl = txtMenuUrl.Text;
            menu.Id = Convert.ToInt32(lblMenuId.Text);

            var selectedItem = cmbParentMenu.SelectedItem == null ? "" : cmbParentMenu.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(selectedItem))
            {
                var arr = selectedItem.Split(':');
                menu.ParentId = Convert.ToInt32(arr[0]);
            }
            else
            {
                menu.ParentId = null;
            }

            var res = _menu.Update(menu);
            if (res)
            {
                MessageBox.Show("Record Updated");
                loadData();
                txtMenuName.Text = "";
                txtMenuUrl.Text = "";
            }
            else
            {
                MessageBox.Show("Some Error Occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            var Id = Convert.ToInt32(lblMenuId.Text);

           
            var res = _menu.Delete(Id);
            if (res)
            {
                MessageBox.Show("Record Deleted");
                loadData();
                txtMenuName.Text = "";
                txtMenuUrl.Text = "";
            }
            else
            {
                MessageBox.Show("Some Error Occured");
            }
        }
    }
}
