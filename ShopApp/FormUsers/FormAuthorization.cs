using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.FormUsers
{
    public partial class FormAuthorization : Form
    {
        public string EmailLogin { get { return txtEmailLogin.Text; } }
        public string PasswordUser { get { return txtPasswordAuth.Text; } }

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            if (GetPasswordByEmail(context, EmailLogin) == PasswordUser)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильний пароль або емейл, спробуйте ще раз.");
            }
        }

        private string GetPasswordByEmail(ApplicationDbContext context, string email)
        {
            foreach (var item in context.Users)
            {
                if(item.Email == email)
                {
                    return item.Password;
                }
            }
            return null;
        }
    }
}
