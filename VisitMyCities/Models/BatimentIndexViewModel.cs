using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models
{
    public class BatimentIndexViewModel
    {
        public PaginatedList<Batiment> BatimentsIndex { get; set; }

        public ICollection<Categorie> Categories { get; set; }
    }
}
