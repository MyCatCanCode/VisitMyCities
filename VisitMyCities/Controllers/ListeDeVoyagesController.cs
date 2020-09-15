using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.Controllers
{
    
    public class ListeDeVoyagesController : Controller
    {
        private readonly VisitMyCitiesContext _context;

        public ListeDeVoyagesController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: ListeDeVoyages
        public async Task<IActionResult> Index()
        {
            var visitMyCitiesContext = _context.ListesDeVoyage.Include(l => l.Ville);
            return View(await visitMyCitiesContext.ToListAsync());
        }

        // GET: ListeDeVoyages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listeDeVoyage = await _context.ListesDeVoyage
                .FirstOrDefaultAsync(m => m.IdListe == id);
            if (listeDeVoyage == null)
            {
                return NotFound();
            }

            return View(listeDeVoyage);
        }

        // GET: ListeDeVoyages/Create
        public IActionResult Create()
        {
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille");
            return View();
        }

        // POST: ListeDeVoyages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdListe,TitreListe,VilleId,URLBlason")] ListeDeVoyage listeDeVoyage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listeDeVoyage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "NomVille", listeDeVoyage.VilleId);
            return View(listeDeVoyage);
        }

        // GET: ListeDeVoyages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listeDeVoyage = await _context.ListesDeVoyage.FindAsync(id);
            if (listeDeVoyage == null)
            {
                return NotFound();
            }
            return View(listeDeVoyage);
        }

        // POST: ListeDeVoyages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdListe,TitreListe")] ListeDeVoyage listeDeVoyage)
        {
            if (id != listeDeVoyage.IdListe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listeDeVoyage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListeDeVoyageExists(listeDeVoyage.IdListe))
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
            return View(listeDeVoyage);
        }

        // GET: ListeDeVoyages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listeDeVoyage = await _context.ListesDeVoyage
                .FirstOrDefaultAsync(m => m.IdListe == id);
            if (listeDeVoyage == null)
            {
                return NotFound();
            }

            return View(listeDeVoyage);
        }

        // POST: ListeDeVoyages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listeDeVoyage = await _context.ListesDeVoyage.FindAsync(id);
            _context.ListesDeVoyage.Remove(listeDeVoyage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListeDeVoyageExists(int id)
        {
            return _context.ListesDeVoyage.Any(e => e.IdListe == id);
        }
    }
}
