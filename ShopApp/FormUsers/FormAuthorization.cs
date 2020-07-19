using ShopApp.Entities;
using SimpleCrypto;
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
        ApplicationDbContext _context;

        public FormAuthorization()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PasswordUser))
            {
                MessageBox.Show("Пароль пустий.");
                return;
            }
            var user = GetUserByEmail(EmailLogin);
            if(user!=null)
            {
                ICryptoService cryptoService = new PBKDF2();
                // validate user
                string password = PasswordUser;
                string salt = user.PasswordHash;
                string hashedPassword2 = cryptoService.Compute(password, salt);
                bool isPasswordValid = cryptoService.Compare(user.Password, hashedPassword2);
                if(isPasswordValid)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неправильний пароль або емейл, спробуйте ще раз.");
                }
            }
            else
            {
                MessageBox.Show("Неправильний пароль або емейл, спробуйте ще раз.");
            }
        }

        private DbUser GetUserByEmail(string email)
        {
            var user = _context.Users
                .Where(x=>x.Deleted==false)
                .SingleOrDefault(u=>u.Email==email);
            //foreach (var item in context.Users)
            //{
            //    if(item.Email == email)
            //    {
            //        return item.Password;
            //    }
            //}
            return user;
        }
    }
}
