using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.FormUsers
{
    public partial class FormUpdateUser : Form
    {
        public string UserFN { get { return newtxtFN.Text; } }
        public string UserLN { get { return newtxtLN.Text; } }
        public string ImageSelect { get; private set; }
        public string UserPhone { get { return newtxtPhone.Text; } }
        public string UserEmail { get { return newtxtEmail.Text; } }
        public string UserPassword { get { return newtxtPassword.Text; } }
        public string Code { get { return newtxtCode.Text; } }
        private string CodeVal;

        public FormUpdateUser()
        {
            InitializeComponent();
            newuImage.Image = Image.FromFile("images/noimage.png");
            newuImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void newbtnSelectUserImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файли зображення|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            dialog.Title = "Оберіть фото для користувача.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ImageSelect = dialog.FileName;
                newuImage.Image = Image.FromFile(this.ImageSelect);
            }
        }

        private void newbtnGetCode_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("formswindows@gmail.com");
            MailAddress toMailAddress = new MailAddress(UserEmail);

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))
            {
                using (SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    mailMessage.Subject = "Шорти Incorporated | Реєстрація | Код";
                    CodeVal = (new Random()).Next(1000, 9000).ToString();
                    mailMessage.Body = CodeVal;

                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Qvw-6Xr-Dn7-rw8");

                    smtpClient.Send(mailMessage);

                    MessageBox.Show("Код надіслано. Прийде протягом кількох хвилин.");
                }
            }
        }

        private void newbntOk_Click(object sender, EventArgs e)
        {
            if (CodeVal == Code)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильний код або емейл, спробуйте ще раз.");
            }
        }
    }
}
