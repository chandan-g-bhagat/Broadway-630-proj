using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Model
{
    public class CustomerDetails
    {
       
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)] //attributes
        public string CustomerName { get; set; }
        
        [MaxLength(50)]
        public string CustomerAddress { get; set; }
       
        public string Phone { get; set; }

        public int? Userid { get; set; }

        [ForeignKey("Userid")]
        public virtual UserDetails User { get; set; }
    }

    [Table("User_Info")]
    public class UserDetails
    {
        [Column(Order =0)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [Column("EmailAddress", Order =1)]
        public string Email { get; set; }
    }
}
