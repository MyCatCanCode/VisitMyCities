using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;
using VisitMyCities.Models.DTOs;

namespace VisitMyCities.Controllers.API
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BatimentsController : ControllerBase
    {
        IRepository _repos;
        public BatimentsController(IRepository repos)
        {
            _repos = repos;
        }

        // GET: api/Batiments
        [HttpGet]
        public IEnumerable<BatimentDTO> Get()
        {
            var batiments = _repos.GetAll<Batiment>();
            return batiments.Select(b => new BatimentDTO(b));
        }

        // GET: api/Villes/DetailsParBatiment/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<DetailArchitectural>> DetailsParBatiment(int id)
        {
            var batimentRecherche = _repos.GetById<Batiment>(id);

            if (batimentRecherche == null)
            {
                return NotFound();
            }

            var batiments = _repos.GetAll<Batiment>();
            var details = _repos.GetAll<DetailArchitectural>();
            var ListeDetailParBatiment = new List<DetailArchitectural>();

            var query = from batiment in batiments
                        join detail in details on batiment.BatimentId equals detail.BatimentId
                        where batiment.BatimentId == batimentRecherche.BatimentId
                        select new DetailArchitectural
                        {
                            NomDetail = detail.NomDetail,
                            DescriptionDetail = detail.DescriptionDetail
                        };


            foreach (var detail in query)
            {
                Console.WriteLine(detail);
                ListeDetailParBatiment.Add(detail);

            }


            return ListeDetailParBatiment;
        }

        // GET: api/Batiments/5
        [HttpGet("{id}")]
        public BatimentDTO Get(int id)
        {
            Batiment batiment = _repos.GetById<Batiment>(id);
            return new BatimentDTO(batiment);
        }

        // PUT: api/Batiments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut]
        public void Put(BatimentDTO dto)
        {
            Batiment bat = (Batiment)dto;
            _repos.Update(bat);
        }

        // POST: api/Batiments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void Post(BatimentDTO dto)
        {
            Batiment bat = (Batiment)dto;
            _repos.Insert(bat);
        }

        // DELETE: api/Batiments/5
        [HttpDelete]
        public void DeleteBatiment(BatimentDTO dto)
        {
            Batiment bat = (Batiment)dto;
            _repos.Delete(bat);
        }

        //private bool BatimentExists(int id)
        //{
        //    return _context.Batiments.Any(e => e.BatimentId == id);
        //}
    }
}
