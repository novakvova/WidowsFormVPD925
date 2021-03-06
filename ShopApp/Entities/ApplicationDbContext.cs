﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<DbUser> Users { get; set; }

        public DbSet<DbRole> Roles { get; set; }

        public DbSet<DbUserRole> UserRoles { get; set; }
    }
}
