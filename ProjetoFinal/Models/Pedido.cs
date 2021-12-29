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
        public int IdPedido { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        public DateTime PrazoEntrega { get; set; }

        // FK Cliente
        [Required]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public List<ItemPedido> ItensPedido { get; set; }

        public Pedido()
        {
            this.DataPedido = DateTime.Today;
            this.PrazoEntrega = DataPedido.AddDays(10);
        }
    }
}
