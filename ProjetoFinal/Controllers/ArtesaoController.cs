﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class ArtesaoController : Controller
    {
        private readonly ProjetoFinalDbContext _context;

        public ArtesaoController(ProjetoFinalDbContext context)
        {
            _context = context;
        }

        // GET: Artesao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Artesao.ToListAsync());
        }

        // GET: Artesao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesao = await _context.Artesao
                .FirstOrDefaultAsync(m => m.IdArtesao == id);
            if (artesao == null)
            {
                return NotFound();
            }

            return View(artesao);
        }

        // GET: Artesao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artesao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdArtesao,NomeArtesao,senha,email")] Artesao artesao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artesao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artesao);
        }

        // GET: Artesao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesao = await _context.Artesao.FindAsync(id);
            if (artesao == null)
            {
                return NotFound();
            }
            return View(artesao);
        }

        // POST: Artesao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdArtesao,NomeArtesao,senha,email")] Artesao artesao)
        {
            if (id != artesao.IdArtesao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artesao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtesaoExists(artesao.IdArtesao))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(artesao);
        }

        // GET: Artesao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artesao = await _context.Artesao
                .FirstOrDefaultAsync(m => m.IdArtesao == id);
            if (artesao == null)
            {
                return NotFound();
            }

            return View(artesao);
        }

        // POST: Artesao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artesao = await _context.Artesao.FindAsync(id);
            _context.Artesao.Remove(artesao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtesaoExists(int id)
        {
            return _context.Artesao.Any(e => e.IdArtesao == id);
        }
    }
}
