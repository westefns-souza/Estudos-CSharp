using Microsoft.EntityFrameworkCore;
using projeto.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto.Data.Context
{
    class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
