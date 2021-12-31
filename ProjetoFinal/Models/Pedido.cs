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

        // FK Cliente
        [Required]
        public int ClienteIdCliente { get; set; }
        public Cliente Cliente { get; set; }

        //Fk Produto
        public int ProdutoIdProduto { get; set; }
        public Produto Produto { get; set; }

        public Pedido()
        {
            this.DataPedido = DateTime.Today;
        }
    }
}
