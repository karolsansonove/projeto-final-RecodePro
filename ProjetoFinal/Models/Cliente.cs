using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        public int IdCliente { get; set; }
    }
}