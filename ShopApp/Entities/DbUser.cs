using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    [Table("tblUsers")]
    public class DbUser
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(150)]
        public string Image { get; set; }
        [Required, StringLength(20)]
        public string MobilePhoneNumber { get; set; }

        public DateTime DateRegistered { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool Deleted { get; set; }

        [Required, StringLength(150)]
        public string Email { get; set; }

        [Required, StringLength(150)]
        public string Password { get; set; }

        [Required, StringLength(150)]
        public string PasswordHash { get; set; }
        public virtual ICollection<DbUserRole> DbUserRoles { get; set; }
    }
}
