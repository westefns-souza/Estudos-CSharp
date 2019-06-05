using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Business.Models;
using Data.Context;
using Business.Interfaces;
using AutoMapper;
using App.ViewModels;

namespace App.Controllers
{
    public class AvaliacaoController : Controller
    {
        private readonly MeuDbContext _context;
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IMapper _mapper;

        public AvaliacaoController(IAvaliacaoRepository avaliacaoRepository,
                                   IMapper mapper,
                                   MeuDbContext context)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<AvaliacaoViewModel>>(await _avaliacaoRepository.ObterTodos()));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterPorId(id));

            if (avaliacaoViewModel == null) return NotFound();

            return View(avaliacaoViewModel);
        }

        public IActionResult Create()
        {
            ViewData["IdSistema"] = new SelectList(_context.Sistemas, "Id", "NomeSistema");
            return View(new AvaliacaoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AvaliacaoViewModel avaliacaoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _avaliacaoRepository.Adicionar(_mapper.Map<Avaliacao>(avaliacaoViewModel));
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdSistema"] = new SelectList(_context.Sistemas, "Id", "NomeSistema", avaliacaoViewModel.IdSistema);
            return View(avaliacaoViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var avaliacaoViewModel = await _avaliacaoRepository.ObterPorId(id);

            if (avaliacaoViewModel == null) return NotFound();

            ViewData["IdSistema"] = new SelectList(_context.Sistemas, "Id", "NomeSistema", avaliacaoViewModel.IdSistema);
            return View(avaliacaoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AvaliacaoViewModel avaliacaoViewModel)
        {
            if (id != avaliacaoViewModel.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _avaliacaoRepository.Atualizar(_mapper.Map<Avaliacao>(avaliacaoViewModel));

                return RedirectToAction(nameof(Index));
            }

            ViewData["IdSistema"] = new SelectList(_context.Sistemas, "Id", "NomeSistema", avaliacaoViewModel.IdSistema);
            return View(avaliacaoViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var avaliacaoViewModel = _mapper.Map<AvaliacaoViewModel>(await _avaliacaoRepository.ObterPorId(id));

            if (avaliacaoViewModel == null) return NotFound();

            return View(avaliacaoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _avaliacaoRepository.Remover(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
