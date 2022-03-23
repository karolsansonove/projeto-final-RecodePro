using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoFinal.Data;
using ProjetoFinal.Models;

namespace ProjetoFinal.Logic
{
    public class CarrinhoDeComprasActions : IDisposable
    {
        public string IdCarrinhoDeCompras { get; set; }
        private ProjetoFinalDbContext _db = new ProjetoFinalDbContext();
        public const string CarrinhoSessionKey = "CarrinhoId";
        public void AddToCarrinho(int id)
        {
            //Traz o produto do banco de dados.
            IdCarrinho = GetIdCarrinho();

            var itemCarrinho = _db.ShoppingItensCarrinho.SingleOrDefault(
                c => c.CarrinhoId == CarrinhoId
                && c.IdProduto == id);
            if (itemCarrinho == null)
            {
                //Cria um novo Carrinho de itens se não existir um
                itemCarrinho = new ItemCarrinho
                {
                    IdItem = Guid.NewGuid().ToString(),
                    ProdutoIdProduto = id,
                    IdCarrinho = IdCarrinho
                };
            }
        }
    }
}
