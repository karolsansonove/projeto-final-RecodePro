using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key]
        public int IdItemPedido { get; set; }

        [Required]
        public int Quantidade { get; set; }

        // FK Produto
        [Required]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

        // FK Pedido
        [Required]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}