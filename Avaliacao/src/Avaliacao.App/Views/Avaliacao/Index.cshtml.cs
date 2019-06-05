using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Business.Models;
using Data.Context;

namespace App.Views
{
    public class IndexModel : PageModel
    {
        private readonly Data.Context.MeuDbContext _context;

        public IndexModel(Data.Context.MeuDbContext context)
        {
            _context = context;
        }

        public IList<Avaliacao> Avaliacao { get;set; }

        public async Task OnGetAsync()
        {
            Avaliacao = await _context.Avaliacoes
                .Include(a => a.Sistema).ToListAsync();
        }
    }
}
