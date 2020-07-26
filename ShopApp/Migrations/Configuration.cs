namespace ShopApp.Migrations
{
    using SimpleCrypto;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopApp.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopApp.Entities.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(r => r.Name, new Entities.DbRole
            {
                Name = "Administrator"
            });
            context.Roles.AddOrUpdate(r => r.Name, new Entities.DbRole
            {
                Name = "User"
            });

            #region Add User Admin

            ICryptoService cryptoService = new PBKDF2();
            //New User
            string password = "Qwerty1-";
            //save this salt to the database
            string salt = cryptoService.GenerateSalt();
            //save this hash to the database
            string hashedPassword = cryptoService.Compute(password);

            context.Users.AddOrUpdate(r => r.Email, new Entities.DbUser
            {
                FirstName = "Толік",
                LastName = "Бригадир",
                Image = "default.jpg",
                MobilePhoneNumber = "+38(097)234-45-31",
                DateRegistered = DateTime.Now,
                LastLoginDate = DateTime.Now,
                Deleted = false,
                Email = "admin@admin.com",
                Password = hashedPassword,
                PasswordHash = salt
            });

            #endregion

            context.SaveChanges();

            var role = context.Roles.SingleOrDefault(r => r.Name == "Administrator");
            var user = context.Users.SingleOrDefault(r => r.Email == "admin@admin.com");


            context.UserRoles.AddOrUpdate(ur => new { ur.UserId, ur.RoleId },
                new Entities.DbUserRole
                {
                    RoleId = role.Id,
                    UserId = user.Id
                });

            role = context.Roles.SingleOrDefault(r => r.Name == "User");
            context.UserRoles.AddOrUpdate(ur => new { ur.UserId, ur.RoleId },
                new Entities.DbUserRole
                {
                    RoleId = role.Id,
                    UserId = user.Id
                });
        }
    }
}
