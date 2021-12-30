using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Artesao")]
    public class Artesao 
    {
        [Key]
        [Required]
        public int IdArtesao { get; set; }

        public char senha { get; set; }
        public string email { get; set; }
    }
}
