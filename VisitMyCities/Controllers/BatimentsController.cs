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
using Microsoft.AspNetCore.Identity;
using VisitMyCities.Models;

namespace VisitMyCities.Controllers
{
    [Route("[controller]/[Action]")]
    public class BatimentsController : Controller
    {
        private readonly VisitMyCitiesContext _context;
        private readonly UserManager<Utilisateur> _userManager;

        public BatimentsController(VisitMyCitiesContext context, UserManager<Utilisateur> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: Batiments
        [AllowAnonymous]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            //var categoriesUniques = _context.BatimentsCategories.Select(bc => new { bc.CategorieId }).Distinct();

            var categoriesUtilisees = (from batcat in _context.BatimentsCategories
                                      join categories in _context.Categories on batcat.CategorieId equals categories.CategorieId into gj
                                      from subbat in gj.DefaultIfEmpty()
                                      //where subbat.CategorieId != id

                                      select new Categorie
                                      {
                                          CategorieId = batcat.CategorieId,
                                          NomCategorie = batcat.Categorie.NomCategorie

                                      }).Distinct();

            ViewData["ListeCategories"] = categoriesUtilisees.ToList();
            ViewData["ListeOccurences"] = _context.BatimentsCategories.ToList();
            //ViewData["NombreOccurences"] = _context.BatimentsCategories.Count();

            var batiments = _context.Batiments
                .Include(b => b.Ville).Include(ub => ub.BatimentsEvalues) ;

            int pageSize = 6;
            return View(await PaginatedList<Batiment>.CreateAsync(batiments.AsNoTracking(), pageNumber ?? 1, pageSize));

            //return View(await visitMyCitiesContext.ToListAsync());
        }

        [AllowAnonymous]
        // GET: Batiments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var currentUser = _userManager.GetUserId(User);

            // Récupérer l'évaluation de l'utilisateur pour ce bâtiment s'il est connecté.
            if (currentUser != null)
            {
                var stars = _context.UtilisateurBatiment
                    .Where(ub => ub.Utilisateur.Id.Equals(currentUser))
                    .Where(ub => ub.Batiment.BatimentId.Equals(id))
                    .Select(ub => ub.NombreEtoiles)
                    .ToList()
                    .FirstOrDefault();

                ViewData["Utilisateur"] = currentUser;
                ViewData["Etoiles"] = stars;
            }

            // Calculer la moyenne des évaluations pour ce bâtiment

           
                var moyenneEvaluations = _context.UtilisateurBatiment
                    .Where(ub => ub.Batiment.BatimentId.Equals(id))
                    .DefaultIfEmpty()
                    .Average(r => r == null ? 0 : r.NombreEtoiles);

            ViewData["MoyenneEtoiles"] = moyenneEvaluations;
            

            var batiment = await _context.Batiments
                .Include(b => b.Ville)
                .FirstOrDefaultAsync(m => m.BatimentId == id);
            if (batiment == null)
            {
                return NotFound();
            }

            // Récupération des détails architecturaux 
            var detailsArchi = _context.DetailsArchi
                .Where(b => b.BatimentId.Equals(id)).ToList();

            var categories =
                from categorie in _context.Categories
                join batcat in _context.BatimentsCategories on categorie.CategorieId equals batcat.CategorieId
                join bat in _context.Batiments on batcat.BatimentId equals bat.BatimentId

                where bat.BatimentId == id
                select new Categorie
                {
                    CategorieId = categorie.CategorieId,
                    NomCategorie = categorie.NomCategorie,
                };

            var batimentViewModel = new BatimentViewModel
            {
                Batiment = batiment,
                Details = detailsArchi,
                Categories = categories.ToList()
            };

            return View(batimentViewModel);
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

        [AllowAnonymous]
        private bool BatimentExists(int id)
        {
            return _context.Batiments.Any(e => e.BatimentId == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveEvaluation(int id, int starstosave)
        {
            var currentUserId = _userManager.GetUserId(User);

            UtilisateurBatiment ub = new UtilisateurBatiment
            {
                BatimentId = id,
                UtilisateurId = currentUserId,
                NombreEtoiles = starstosave
            };

            await _context.UtilisateurBatiment.AddAsync(ub);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteEvaluation(int? id)
        //{

        //}
    }
}
