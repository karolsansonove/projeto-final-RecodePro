using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Suporte
    {
        [Key]
        [Required]
        public int IdSuporte { get; set; }

        public string Mensagem { get; set; }

        //Fk Cliente
        public int ClienteIdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
