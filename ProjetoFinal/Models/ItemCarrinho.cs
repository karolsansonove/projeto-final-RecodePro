using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Models
{
    public class ItemCarrinho
    {
        [Key]
        public string IdItem { get; set; }
        public string IdCarrinho { get; set; }
        public int Quantidade { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProdutoIdProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
