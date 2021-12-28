using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Vendedor")]
    public class Vendedor : Pessoa
    {
        public int IdVendedor { get; set; }
    }
}
