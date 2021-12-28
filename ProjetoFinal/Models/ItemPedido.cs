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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int IdItemPedido { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public int Quantidade { get; set; }
    }
}