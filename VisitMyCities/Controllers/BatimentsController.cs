﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.Controllers
{
    public class BatimentsController : Controller
    {
        private readonly VisitMyCitiesContext _context;

        public BatimentsController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: Batiments
        public async Task<IActionResult> Index()
        {
            var visitMyCitiesContext = _context.Batiments.Include(b => b.Ville);
            return View(await visitMyCitiesContext.ToListAsync());
        }

        // GET: Batiments/Details/5
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

        // GET: Batiments/Create
        public IActionResult Create()
        {
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille");
            return View();
        }

        // POST: Batiments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BatimentId,NomBatiment,URLPhoto,TypeBatiment,DescriptionBatiment,Longitude,Latitude,MonumentHistorique,DateConstruction,VilleId")] Batiment batiment)
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

        // GET: Batiments/Edit/5
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

        // POST: Batiments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BatimentId,NomBatiment,URLPhoto,TypeBatiment,DescriptionBatiment,Longitude,Latitude,MonumentHistorique,DateConstruction,VilleId")] Batiment batiment)
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

        // GET: Batiments/Delete/5
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

        // POST: Batiments/Delete/5
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