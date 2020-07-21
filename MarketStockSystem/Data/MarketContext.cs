using MarketStockSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStockSystem.Data
{
    public class MarketContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(@"Server=localhost;Database=marketDB;Uid=root;Pwd=admin;");
        }

        public DbSet<Acao> Acoes { get; set; }

    }
}
