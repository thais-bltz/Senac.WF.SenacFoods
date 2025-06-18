using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//biblioteca criada para usar ferramentas

namespace SenacFoods
{
    public class ComandaDBContext : DbContext
    {
        // 1 Construtor do Banco de Dados
        public ComandaDBContext() : base()
        {
            
        }
        // 2 Configurar conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   // 2.1 String de conexão
            var conexao = "Server=localhost;Database=SenacFoods;User=root;Password=";
            // 2.2 Configurar o provedor de banco de dados
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }

    }
}
