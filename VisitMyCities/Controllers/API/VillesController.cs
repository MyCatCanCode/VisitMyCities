using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.Controllers.API
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class VillesController : ControllerBase
    {
        private readonly VisitMyCitiesContext _context;

        public VillesController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: api/Villes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ville>>> GetVilles()
        {
            return await _context.Villes.ToListAsync();
        }

        // GET: api/Villes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ville>> GetVille(int id)
        {
            var ville = await _context.Villes.FindAsync(id);

            if (ville == null)
            {
                return NotFound();
            }



            return ville;
        }

        // GET: api/Villes/BatimentsParVille/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Batiment>>> BatimentsParVille(int id)
        {
            var villeRecherchee = await _context.Villes.FindAsync(id);

            if (villeRecherchee == null)
            {
                return NotFound();
            }

            var villes = _context.Villes;
            var batiments = _context.Batiments;
            var ListeBatimentsParVille = new List<Batiment>();

            var query = from ville in villes
                        join batiment in batiments on ville.VilleId equals batiment.VilleId
                        where ville.VilleId == villeRecherchee.VilleId
                        select new Batiment { NomBatiment = batiment.NomBatiment,
                            TypeBatiment = batiment.TypeBatiment,
                            DescriptionBatiment = batiment.DescriptionBatiment };


            foreach (var batiment in query)
            {
                Console.WriteLine(batiment);
                ListeBatimentsParVille.Add(batiment);
                    
            }


            return ListeBatimentsParVille;
        }

        // PUT: api/Villes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVille(int id, Ville ville)
        {
            if (id != ville.VilleId)
            {
                return BadRequest();
            }

            _context.Entry(ville).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VilleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Villes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ville>> PostVille(Ville ville)
        {
            _context.Villes.Add(ville);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVille", new { id = ville.VilleId }, ville);
        }

        // DELETE: api/Villes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ville>> DeleteVille(int id)
        {
            var ville = await _context.Villes.FindAsync(id);
            if (ville == null)
            {
                return NotFound();
            }

            _context.Villes.Remove(ville);
            await _context.SaveChangesAsync();

            return ville;
        }

        private bool VilleExists(int id)
        {
            return _context.Villes.Any(e => e.VilleId == id);
        }
    }
}
