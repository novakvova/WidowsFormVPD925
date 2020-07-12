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
    public partial class CategoryEditForm : Form
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string FileSelect { get; set; } 
        public CategoryEditForm()
        {
            InitializeComponent();
           
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
                pbImage.Image = Image.FromFile(this.FileSelect);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryName = txtName.Text;
            CategoryDescription = txtDescription.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            var imageBytes = File.ReadAllBytes(FileSelect);
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                pbImage.Image = Image.FromStream(stream);
            }
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            txtName.Text = CategoryName;
            txtDescription.Text = CategoryDescription;
        }
    }
}
