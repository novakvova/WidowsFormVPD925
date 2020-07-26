using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    [Table("tblUserRoles")]
    public class DbUserRole
    {
        [Key, ForeignKey("User"), Column(Order = 0)]
        public int UserId { get; set; }
        [Key, ForeignKey("Role"), Column(Order = 1)]
        public int RoleId { get; set; }
        public virtual DbUser User { get; set; }
        public virtual DbRole Role { get; set; }
    }
}
