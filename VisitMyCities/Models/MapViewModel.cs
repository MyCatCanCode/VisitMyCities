using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models
{
    public class MapViewModel
    {
        public ICollection<Batiment> Batiments { get; set; }
        public ICollection<Ville> Villes { get; set; }
    }
}
