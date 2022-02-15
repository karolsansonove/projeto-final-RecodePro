using Microsoft.AspNetCore.Identity;
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
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Artesao> Artesao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Suporte> Suporte { get; set; }
    }
   
}
