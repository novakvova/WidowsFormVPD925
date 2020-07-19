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
    public partial class FormAddUser : Form
    {
        public string UserFN { get { return txtFN.Text; } }
        public string UserLN { get { return txtLN.Text; } }
        public string ImageSelect { get; private set; }
        public string UserPhone { get { return txtPhone.Text; } }
        public string UserEmail { get { return txtEmail.Text; } }
        public string UserPassword { get { return txtPassword.Text; } }
        public string Code { get { return txtCode.Text; } }
        private string CodeVal;

        public FormAddUser()
        {
            InitializeComponent();
            uImage.Image = Image.FromFile("images/noimage.png");
            uImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntOk_Click(object sender, EventArgs e)
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

        private void btnSelectUserImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файли зображення|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            dialog.Title = "Оберіть фото для користувача.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ImageSelect = dialog.FileName;
                uImage.Image = Image.FromFile(this.ImageSelect);
            }
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            SMTPSender emailSender = new SMTPSender();
            CodeVal = (new Random()).Next(1000, 9000).ToString();
            emailSender.SendMessage(UserEmail, 
                "Шорти Incorporated | Реєстрація | Код",
                $"<b>{CodeVal}</b>");

            //MailAddress fromMailAddress = new MailAddress("formswindows@gmail.com");
            //MailAddress toMailAddress = new MailAddress(UserEmail);

            //using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))
            //{
            //    using (SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
            //    {
            //        mailMessage.Subject = "Шорти Incorporated | Реєстрація | Код";
            //        CodeVal = (new Random()).Next(1000, 9000).ToString();
            //        mailMessage.Body = CodeVal;

            //        smtpClient.EnableSsl = true;
            //        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //        smtpClient.UseDefaultCredentials = false;
            //        smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Qvw-6Xr-Dn7-rw8");

            //        smtpClient.Send(mailMessage);

            //        MessageBox.Show("Код надіслано. Прийде протягом кількох хвилин.");
            //    }
            //}
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void uImage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
