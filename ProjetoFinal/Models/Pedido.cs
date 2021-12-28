using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int IdPedido { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        public DateTime PrazoEntrega { get; set; }

        [Required]
        public int IdCliente { get; set; }
    }
}
