using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;


namespace VisitMyCities.Controllers
{
    public class VillesController : Controller
    {
        private readonly VisitMyCitiesContext _context;
        private readonly UserManager<Utilisateur> _userManager;

        public VillesController(VisitMyCitiesContext context, UserManager<Utilisateur> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Villes
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Villes.ToListAsync());
        }

        // GET: Villes/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentUser = _userManager.GetUserId(User);

            // Récupérer l'évaluation de l'utilisateur pour cette ville s'il est connecté.
            if (currentUser != null)
            {
                var stars = _context.UtilisateurVille
                    .Where(uv => uv.Utilisateur.Id.Equals(currentUser))
                    .Where(uv => uv.Ville.VilleId.Equals(id))
                    .Select(ub => ub.NombreEtoiles)
                    .ToList()
                    .FirstOrDefault();

                ViewData["Utilisateur"] = currentUser;
                ViewData["Etoiles"] = stars;
            }

            // Calculer la moyenne des évaluations pour cette ville


            var moyenneEvaluations = _context.UtilisateurVille
                .Where(uv => uv.Ville.VilleId.Equals(id))
                .DefaultIfEmpty()
                .Average(r => r == null ? 0 : r.NombreEtoiles);

            ViewData["MoyenneEtoiles"] = moyenneEvaluations;

            var ville = await _context.Villes
                .FirstOrDefaultAsync(m => m.VilleId == id);
            if (ville == null)
            {
                return NotFound();
            }

            return View(ville);
        }

        // GET: Villes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Villes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VilleId,NomVille,NomRegion,NumDepartement,NomDepartement")] Ville ville)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ville);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ville);
        }

        // GET: Villes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ville = await _context.Villes.FindAsync(id);
            if (ville == null)
            {
                return NotFound();
            }
            return View(ville);
        }

        // POST: Villes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VilleId,NomVille,NomRegion,NumDepartement,NomDepartement")] Ville ville)
        {
            if (id != ville.VilleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ville);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VilleExists(ville.VilleId))
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
            return View(ville);
        }

        // GET: Villes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ville = await _context.Villes
                .FirstOrDefaultAsync(m => m.VilleId == id);
            if (ville == null)
            {
                return NotFound();
            }

            return View(ville);
        }

        // POST: Villes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ville = await _context.Villes.FindAsync(id);
            _context.Villes.Remove(ville);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VilleExists(int id)
        {
            return _context.Villes.Any(e => e.VilleId == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task SaveEvaluation(int id, int starstosave)
        {
            var currentUserId = _userManager.GetUserId(User);

            UtilisateurVille uv = new UtilisateurVille
            {
                VilleId = id,
                UtilisateurId = currentUserId,
                NombreEtoiles = starstosave
            };

            await _context.UtilisateurVille.AddAsync(uv);
            await _context.SaveChangesAsync();


        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteEvaluation(int? id)
        //{

        //}
    }
}
