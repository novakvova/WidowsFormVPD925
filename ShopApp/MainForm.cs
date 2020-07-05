using ShopApp.Categories;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            ApplicationDbContext context = new ApplicationDbContext();
            foreach (var item in context.Categories)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", item.Image);

                dgvCategories.Rows.Add(new object[]
                {
                    item.Id,
                    item.Name,
                    Image.FromFile(path),
                    item.Description
                });
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryCreateForm dlg = new CategoryCreateForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string name = dlg.CategoryName;
                string description = dlg.CategoryDescription;
                string file = dlg.FileSelect;
                
                string extension = Path.GetExtension(file);
                string nameFile = Path.GetRandomFileName() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), 
                    "images", nameFile);

                File.Copy(file, path);

                ApplicationDbContext context = new ApplicationDbContext();
                Category category = new Category
                {
                    Name = name,
                    Image = nameFile,
                    Description = description
                };
                context.Categories.Add(category);
                context.SaveChanges();

                dgvCategories.Rows.Add(new object[] { category.Id, category.Name });
                MessageBox.Show("Можна зберігати в БД");
            }
        }
    }
}
