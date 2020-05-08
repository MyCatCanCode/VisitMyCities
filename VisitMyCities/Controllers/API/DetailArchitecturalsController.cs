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
    public class DetailArchitecturalsController : ControllerBase
    {
        private readonly VisitMyCitiesContext _context;

        public DetailArchitecturalsController(VisitMyCitiesContext context)
        {
            _context = context;
        }

        // GET: api/DetailArchitecturals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetailArchitectural>>> GetDetailsArchi()
        {
            return await _context.DetailsArchi.ToListAsync();
        }

        // GET: api/DetailArchitecturals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailArchitectural>> GetDetailArchitectural(int id)
        {
            var detailArchitectural = await _context.DetailsArchi.FindAsync(id);

            if (detailArchitectural == null)
            {
                return NotFound();
            }

            return detailArchitectural;
        }

        // PUT: api/DetailArchitecturals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetailArchitectural(int id, DetailArchitectural detailArchitectural)
        {
            if (id != detailArchitectural.DetailId)
            {
                return BadRequest();
            }

            _context.Entry(detailArchitectural).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailArchitecturalExists(id))
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

        // POST: api/DetailArchitecturals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DetailArchitectural>> PostDetailArchitectural(DetailArchitectural detailArchitectural)
        {
            _context.DetailsArchi.Add(detailArchitectural);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetailArchitectural", new { id = detailArchitectural.DetailId }, detailArchitectural);
        }

        // DELETE: api/DetailArchitecturals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DetailArchitectural>> DeleteDetailArchitectural(int id)
        {
            var detailArchitectural = await _context.DetailsArchi.FindAsync(id);
            if (detailArchitectural == null)
            {
                return NotFound();
            }

            _context.DetailsArchi.Remove(detailArchitectural);
            await _context.SaveChangesAsync();

            return detailArchitectural;
        }

        private bool DetailArchitecturalExists(int id)
        {
            return _context.DetailsArchi.Any(e => e.DetailId == id);
        }
    }
}
