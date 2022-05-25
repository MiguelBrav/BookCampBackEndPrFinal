using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Models
{
    [Table("Usuarios")]
    public class User
        
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Pass")]
        public string Pass { get; set; }

        //public string Session { get; set; }

    }
}
