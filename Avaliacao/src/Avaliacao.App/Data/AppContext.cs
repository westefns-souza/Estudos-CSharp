using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.ViewModels;

namespace App.Models
{
    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<App.ViewModels.SistemaViewModel> SistemaViewModel { get; set; }
        public DbSet<App.ViewModels.AvaliacaoViewModel> AvaliacaoViewModel { get; set; }
    }
}
