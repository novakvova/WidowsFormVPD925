using ShopApp.Categories;
using ShopApp.Entities;
using ShopApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext context;
        public MainForm()
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            UpdateAlldgvCategories();

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

                //File.Copy(file, path);
                var bmp = ImageHelper.CompressImage(Image.FromFile(file), 120, 80);
                bmp.Save(path, ImageFormat.Jpeg);

                
                Category category = new Category
                {
                    Name = name,
                    Image = nameFile,
                    Description = description
                };
                context.Categories.Add(category);
                context.SaveChanges();

                UpdateAlldgvCategories();
                //var imageBytes = File.ReadAllBytes(path);
                //using (MemoryStream stream = new MemoryStream(imageBytes))
                //{
                //    dgvCategories.Rows.Add(new object[] { category.Id, category.Name, Image.FromStream(stream),
                //    category.Description });
                //}
                MessageBox.Show("Можна зберігати в БД");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvCategories.SelectedRows[0];
                var id = int.Parse(row.Cells["ColId"].Value.ToString());
                var cat = context.Categories.SingleOrDefault(c => c.Id == id);
                if(cat!=null)
                {
                    CategoryEditForm dlg = new CategoryEditForm();

                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", cat.Image);

                    dlg.FileSelect = path;
                    dlg.CategoryName = cat.Name;
                    dlg.CategoryDescription = cat.Description;

                    if(dlg.ShowDialog() == DialogResult.OK)
                    {
                        //мы змінили файл категорії
                        if (path != dlg.FileSelect)
                        {
                            var bmp = ImageHelper.CompressImage(Image.FromFile(dlg.FileSelect), 120, 80);
                            bmp.Save(path, ImageFormat.Jpeg); //Зберігаємо під тоюж самою назвою
                        }
                        //cat = context.Categories.SingleOrDefault(c => c.Id == id);
                        cat.Name = dlg.CategoryName;
                        cat.Description = dlg.CategoryDescription;
                        context.SaveChanges();
                        UpdateAlldgvCategories();
                    }

                }
                
                
                //MessageBox.Show("Id = ", id.ToString());
            }
        }

        private void UpdateAlldgvCategories()
        {
            dgvCategories.Rows.Clear();
            foreach (var category in context.Categories)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", category.Image);

                var imageBytes = File.ReadAllBytes(path);
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    dgvCategories.Rows.Add(new object[] { category.Id, category.Name, Image.FromStream(stream),
                    category.Description });
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvCategories.SelectedRows[0];
                var id = int.Parse(row.Cells["ColId"].Value.ToString());
                var cat = context.Categories.SingleOrDefault(c => c.Id == id);
                if (cat != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", cat.Image);
                    File.Delete(path);
                    context.Categories.Remove(cat);
                    context.SaveChanges();
                    UpdateAlldgvCategories();
                }
            }
        }
    }
}
