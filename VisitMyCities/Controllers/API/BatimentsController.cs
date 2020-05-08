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
    [Route("api/[controller]")]
    [ApiController]
    public class BatimentsController : ControllerBase
    {
        private readonly VisitMyCitiesContext _context;

        public BatimentsController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: api/Batiments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Batiment>>> GetBatiments()
        {
            return await _context.Batiments.ToListAsync();
        }

        // GET: api/Batiments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Batiment>> GetBatiment(int id)
        {
            var batiment = await _context.Batiments.FindAsync(id);

            if (batiment == null)
            {
                return NotFound();
            }

            return batiment;
        }

        // PUT: api/Batiments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatiment(int id, Batiment batiment)
        {
            if (id != batiment.BatimentId)
            {
                return BadRequest();
            }

            _context.Entry(batiment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BatimentExists(id))
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

        // POST: api/Batiments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Batiment>> PostBatiment(Batiment batiment)
        {
            _context.Batiments.Add(batiment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBatiment", new { id = batiment.BatimentId }, batiment);
        }

        // DELETE: api/Batiments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Batiment>> DeleteBatiment(int id)
        {
            var batiment = await _context.Batiments.FindAsync(id);
            if (batiment == null)
            {
                return NotFound();
            }

            _context.Batiments.Remove(batiment);
            await _context.SaveChangesAsync();

            return batiment;
        }

        private bool BatimentExists(int id)
        {
            return _context.Batiments.Any(e => e.BatimentId == id);
        }
    }
}
