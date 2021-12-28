using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Data
{
    public class ProjetoFinalDbContext : DbContext
    {
        public ProjetoFinalDbContext(DbContextOptions<ProjetoFinalDbContext> opt) : base(opt)
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemsPedidos { get; set; }
    }
}
