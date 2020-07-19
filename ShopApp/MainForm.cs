using ShopApp.Categories;
using ShopApp.FormUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void headMenu_file_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void headMenu_data_users_Click(object sender, EventArgs e)
        {
            ListUsersForm dlg = new ListUsersForm();
            dlg.ShowDialog();
        }

        private void headMenu_data_categories_Click(object sender, EventArgs e)
        {
            CategoryListForm dlg = new CategoryListForm();
            dlg.ShowDialog();
        }
    }
}
