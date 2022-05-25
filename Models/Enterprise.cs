using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Models
{
    [Table("Empresas")]
    public class Enterprise
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nom_Emp")]
        public string Nom_Emp { get; set; }

        [Column("Cant_Vacan")]
        public int Cant_Vacan { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

    }
}
