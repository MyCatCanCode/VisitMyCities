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
    public class DetailArchitecturalsController : Controller
    {
        private readonly VisitMyCitiesContext _context;

        public DetailArchitecturalsController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: DetailArchitecturals
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var visitMyCitiesContext = _context.DetailsArchi.Include(d => d.Batiment);
            return View(await visitMyCitiesContext.ToListAsync());
        }

        // GET: DetailArchitecturals/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailArchitectural = await _context.DetailsArchi
                .Include(d => d.Batiment)
                .FirstOrDefaultAsync(m => m.DetailId == id);
            if (detailArchitectural == null)
            {
                return NotFound();
            }

            return View(detailArchitectural);
        }

        // GET: DetailArchitecturals/Create
        public IActionResult Create()
        {
            ViewData["BatimentId"] = new SelectList(_context.Batiments, "BatimentId", "NomBatiment");
            return View();
        }

        // POST: DetailArchitecturals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetailId,NomDetail,DescriptionDetail,BatimentId")] DetailArchitectural detailArchitectural)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detailArchitectural);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BatimentId"] = new SelectList(_context.Batiments, "BatimentId", "NomBatiment", detailArchitectural.BatimentId);
            return View(detailArchitectural);
        }

        // GET: DetailArchitecturals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailArchitectural = await _context.DetailsArchi.FindAsync(id);
            if (detailArchitectural == null)
            {
                return NotFound();
            }
            ViewData["BatimentId"] = new SelectList(_context.Batiments, "BatimentId", "NomBatiment", detailArchitectural.BatimentId);
            return View(detailArchitectural);
        }

        // POST: DetailArchitecturals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetailId,NomDetail,DescriptionDetail,BatimentId")] DetailArchitectural detailArchitectural)
        {
            if (id != detailArchitectural.DetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detailArchitectural);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailArchitecturalExists(detailArchitectural.DetailId))
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
            ViewData["BatimentId"] = new SelectList(_context.Batiments, "BatimentId", "NomBatiment", detailArchitectural.BatimentId);
            return View(detailArchitectural);
        }

        // GET: DetailArchitecturals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailArchitectural = await _context.DetailsArchi
                .Include(d => d.Batiment)
                .FirstOrDefaultAsync(m => m.DetailId == id);
            if (detailArchitectural == null)
            {
                return NotFound();
            }

            return View(detailArchitectural);
        }

        // POST: DetailArchitecturals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detailArchitectural = await _context.DetailsArchi.FindAsync(id);
            _context.DetailsArchi.Remove(detailArchitectural);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetailArchitecturalExists(int id)
        {
            return _context.DetailsArchi.Any(e => e.DetailId == id);
        }
    }
}
