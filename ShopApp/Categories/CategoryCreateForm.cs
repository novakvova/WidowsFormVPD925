using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Categories
{
    public partial class CategoryCreateForm : Form
    {
        public string CategoryName { get { return txtName.Text; } }
        public string CategoryDescription { get { return txtDescription.Text; } }
        public string FileSelect { get; private set; } 
        public CategoryCreateForm()
        {
            InitializeComponent();
            pbImage.Image = Image.FromFile("images/noimage.png");
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файли зображення|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            //dialog.InitialDirectory = @"C:\";
            dialog.Title = "Оберіть фото для категорії.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FileSelect = dialog.FileName;
                //byte[] bytes = File.ReadAllBytes(this.FileSelect);
                //var image = FileHelper.ByteToImage(bytes);
                //pbImage.Image = FileHelper.ByteToImage(bytes); // Image.FromFile(this.FileSelect);
                pbImage.Image = Image.FromFile(this.FileSelect);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
