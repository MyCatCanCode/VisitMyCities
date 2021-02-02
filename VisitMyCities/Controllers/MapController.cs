using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;
using VisitMyCities.Models;

namespace VisitMyCities.Controllers
{
    public class MapController : Controller
    {
        private readonly VisitMyCitiesContext _context;

        public MapController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: Map
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var batiments = _context.Batiments.ToList();
            var villes = _context.Villes.ToList();
            var mapViewModel = new MapViewModel
            {
                Batiments = batiments,
                Villes = villes
            };
            return View(mapViewModel);
        }

        // GET: Map/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batiment = await _context.Batiments
                .Include(b => b.Ville)
                .FirstOrDefaultAsync(m => m.BatimentId == id);
            if (batiment == null)
            {
                return NotFound();
            }

            return View(batiment);
        }

        // GET: Map/Create
        public IActionResult Create()
        {
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille");
            return View();
        }

        // POST: Map/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BatimentId,NomBatiment,Adresse,URLPhoto,TypeBatiment,DescriptionBatiment,Longitude,Latitude,MonumentHistorique,DateConstruction,VilleId")] Batiment batiment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(batiment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille", batiment.VilleId);
            return View(batiment);
        }

        // GET: Map/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batiment = await _context.Batiments.FindAsync(id);
            if (batiment == null)
            {
                return NotFound();
            }
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille", batiment.VilleId);
            return View(batiment);
        }

        // POST: Map/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BatimentId,NomBatiment,Adresse,URLPhoto,TypeBatiment,DescriptionBatiment,Longitude,Latitude,MonumentHistorique,DateConstruction,VilleId")] Batiment batiment)
        {
            if (id != batiment.BatimentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(batiment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BatimentExists(batiment.BatimentId))
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
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille", batiment.VilleId);
            return View(batiment);
        }

        // GET: Map/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batiment = await _context.Batiments
                .Include(b => b.Ville)
                .FirstOrDefaultAsync(m => m.BatimentId == id);
            if (batiment == null)
            {
                return NotFound();
            }

            return View(batiment);
        }

        // POST: Map/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var batiment = await _context.Batiments.FindAsync(id);
            _context.Batiments.Remove(batiment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BatimentExists(int id)
        {
            return _context.Batiments.Any(e => e.BatimentId == id);
        }
    }
}
