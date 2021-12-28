using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [StringLength(80)]
        public string Nome { get; set; }

        [StringLength(140)]
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string UrlImagem { get; set; }

        // FK Vendedor
        public int IdVendedor { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}