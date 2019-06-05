using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Business.Models;
using Data.Context;

namespace App.Views
{
    public class CreateModel : PageModel
    {
        private readonly Data.Context.MeuDbContext _context;

        public CreateModel(Data.Context.MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdSistema"] = new SelectList(_context.Sistemas, "Id", "NomeSistema");
            return Page();
        }

        [BindProperty]
        public Avaliacao Avaliacao { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Avaliacoes.Add(Avaliacao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}