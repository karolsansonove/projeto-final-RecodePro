using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProjetoFinal.Models
{
    [Table("Artesao")]
    public class Artesao 
    {
        [Key]
        [Required]
        public int IdArtesao { get; set; }

        [StringLength(80)]
        public string NomeArtesao { get; set; }

        [StringLength(8)]
        public string senha { get; set; }

        [StringLength(45)]
        public string email { get; set; }
    }
}
