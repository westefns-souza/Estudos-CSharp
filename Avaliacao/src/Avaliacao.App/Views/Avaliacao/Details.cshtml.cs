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
    public class DetailsModel : PageModel
    {
        private readonly Data.Context.MeuDbContext _context;

        public DetailsModel(Data.Context.MeuDbContext context)
        {
            _context = context;
        }

        public Avaliacao Avaliacao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Avaliacao = await _context.Avaliacoes
                .Include(a => a.Sistema).FirstOrDefaultAsync(m => m.Id == id);

            if (Avaliacao == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
