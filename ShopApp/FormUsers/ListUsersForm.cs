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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.FormUsers
{
    public partial class ListUsersForm : Form
    {
        public ListUsersForm()
        {
            InitializeComponent();

            ApplicationDbContext context = new ApplicationDbContext();

            UpdateUsersGrid(context);
        }

        private void UpdateUsersGrid(ApplicationDbContext context)
        {
            dgvUsers.Rows.Clear();
            foreach (var item in context.Users)
            {
                if (!item.Deleted)
                {
                    var pathTmp = Path.Combine(Directory.GetCurrentDirectory(), "images", item.Image);
                    if (File.Exists(pathTmp))
                    {
                        var imageBytes = File.ReadAllBytes(pathTmp);

                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            dgvUsers.Rows.Add(new object[] { item.Id, item.FirstName, item.LastName, Image.FromStream(ms), item.MobilePhoneNumber,
                        item.DateRegistered, item.LastLoginDate, item.Email});
                        }
                    }
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddUser dlg = new FormAddUser();
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    string extension = Path.GetExtension(dlg.ImageSelect);
                    string nameFile = Path.GetRandomFileName() + extension;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                        "images", nameFile);

                    //File.Copy(file, path);
                    var bmp = ImageHelper.CompressImage(Image.FromFile(dlg.ImageSelect), 120, 80);
                    bmp.Save(path, ImageFormat.Jpeg);

                    ApplicationDbContext context = new ApplicationDbContext();
                    DbUser dbUser = new DbUser
                    {
                        FirstName = dlg.UserFN,
                        LastName = dlg.UserLN,
                        Image = nameFile,
                        MobilePhoneNumber = dlg.UserPhone,
                        DateRegistered = DateTime.Now,
                        LastLoginDate = DateTime.Now,
                        Deleted = false,
                        Email = dlg.UserEmail,
                        Password = dlg.UserPassword,
                        PasswordHash = dlg.UserPassword.GetHashCode().ToString()

                    };
                    context.Users.Add(dbUser);
                    context.SaveChanges();

                    UpdateUsersGrid(context);

                    MessageBox.Show("Можна зберігати в БД");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! Користувача не зареєстровано.\n\n" + ex);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 1)
                {
                    ApplicationDbContext context = new ApplicationDbContext();
                    DataGridViewRow row = this.dgvUsers.SelectedRows[0];
                    var id = int.Parse(row.Cells["UserId"].Value.ToString());
                    var cat = context.Users.SingleOrDefault(c => c.Id == id);

                    FormUpdateUser dlg = new FormUpdateUser();
                    if (dlg.ShowDialog() == DialogResult.OK && cat != null)
                    {
                        string extension = Path.GetExtension(dlg.ImageSelect);
                        string nameFile = Path.GetRandomFileName() + extension;
                        var path = Path.Combine(Directory.GetCurrentDirectory(),
                            "images", nameFile);

                        var bmp = ImageHelper.CompressImage(Image.FromFile(dlg.ImageSelect), 120, 80);
                        bmp.Save(path, ImageFormat.Jpeg);

                        var user = context.Users.Find(id);

                        user.FirstName = dlg.UserFN;
                        user.LastName = dlg.UserLN;
                        user.Image = nameFile;
                        user.MobilePhoneNumber = dlg.UserPhone;
                        user.DateRegistered = DateTime.Now;
                        user.LastLoginDate = DateTime.Now;
                        user.Deleted = false;
                        user.Email = dlg.UserEmail;
                        user.Password = dlg.UserPassword;
                        user.PasswordHash = dlg.UserPassword.GetHashCode().ToString();

                        context.SaveChanges();

                        UpdateUsersGrid(context);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! Користувача не змінено.\n\n" + ex);
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 1)
                {
                    ApplicationDbContext context = new ApplicationDbContext();
                    DataGridViewRow row = this.dgvUsers.SelectedRows[0];
                    var id = int.Parse(row.Cells["UserId"].Value.ToString());
                    var cat = context.Users.SingleOrDefault(c => c.Id == id);

                    if (!cat.Deleted)
                    {
                        var user = context.Users.Find(id);
                        user.Deleted = true;
                        context.SaveChanges();

                        UpdateUsersGrid(context);
                        MessageBox.Show("Користувача видалено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! Користувача не видалено.\n\n" + ex);
            }
        }

        private void btnMainAuth_Click(object sender, EventArgs e)
        {
            FormAuthorization dlg = new FormAuthorization();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Авторизація пройшла успішно!");
            }
        }
    }
}
