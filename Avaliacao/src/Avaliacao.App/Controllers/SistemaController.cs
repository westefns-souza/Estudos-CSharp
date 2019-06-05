using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Models;
using App.ViewModels;
using Data.Context;
using Business.Interfaces;
using AutoMapper;
using Business.Models;

namespace App.Controllers
{
    public class SistemaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISistemaRepository _sistemaRepository;

        public SistemaController(ISistemaRepository sistemaRepository,
                                IMapper mapper)
        {
            _sistemaRepository = sistemaRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<SistemaViewModel>>(await _sistemaRepository.ObterTodos()));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var sistemaViewModel = _mapper.Map<SistemaViewModel>(await _sistemaRepository.ObterPorId(id));

            if (sistemaViewModel == null) return NotFound();

            return View(sistemaViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SistemaViewModel sistemaViewModel)
        {
            if (ModelState.IsValid)
            {
                await _sistemaRepository.Adicionar(_mapper.Map<Sistema>(sistemaViewModel));
                return RedirectToAction(nameof(Index));
            }
            return View(sistemaViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var sistemaViewModel = _mapper.Map<SistemaViewModel>(await _sistemaRepository.ObterPorId(id));

            if (sistemaViewModel == null) return NotFound();

            return View(sistemaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SistemaViewModel sistemaViewModel)
        {
            if (id != sistemaViewModel.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _sistemaRepository.Atualizar(_mapper.Map<Sistema>(sistemaViewModel));

                return RedirectToAction(nameof(Index));
            }
            return View(sistemaViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var sistemaViewModel = _mapper.Map<SistemaViewModel>(await _sistemaRepository.ObterPorId(id));

            if (sistemaViewModel == null) return NotFound();

            return View(sistemaViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _sistemaRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
