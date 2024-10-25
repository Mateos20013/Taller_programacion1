using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Taller_programacion.Data;
using Taller_programacion.Models;

namespace Taller_programacion.Controllers
{
    public class EquipoController : Controller
    {
        private readonly Taller_programacionContext _context;

        public EquipoController(Taller_programacionContext context)
        {
            _context = context;
        }

        // GET: Equipo
        public async Task<IActionResult> Index()
        {
            var taller_programacionContext = _context.Equipo.Include(e => e.Estadio);
            return View(await taller_programacionContext.ToListAsync());
        }

        // GET: Equipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .Include(e => e.Estadio)
                .FirstOrDefaultAsync(m => m.IdEquipo == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // GET: Equipo/Create
        public IActionResult Create()
        {
            ViewData["IdEstadio"] = new SelectList(_context.Estadio, "IdEstadio", "Nombre");
            return View();
        }

        // POST: Equipo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEquipo,Nombre,Ciudad,Titulos,AceptaExtranjero,IdEstadio")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEstadio"] = new SelectList(_context.Estadio, "IdEstadio", "Capacidad", equipo.IdEstadio);
            return View(equipo);
        }

        // GET: Equipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }
            ViewData["IdEstadio"] = new SelectList(_context.Estadio, "IdEstadio", "Capacidad", equipo.IdEstadio);
            return View(equipo);
        }

        // POST: Equipo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEquipo,Nombre,Ciudad,Titulos,AceptaExtranjero,IdEstadio")] Equipo equipo)
        {
            if (id != equipo.IdEquipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipoExists(equipo.IdEquipo))
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
            ViewData["IdEstadio"] = new SelectList(_context.Estadio, "IdEstadio", "Capacidad", equipo.IdEstadio);
            return View(equipo);
        }

        // GET: Equipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .Include(e => e.Estadio)
                .FirstOrDefaultAsync(m => m.IdEquipo == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipo = await _context.Equipo.FindAsync(id);
            if (equipo != null)
            {
                _context.Equipo.Remove(equipo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipo.Any(e => e.IdEquipo == id);
        }
    }
}
