using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models
{
    public class CategorieViewModel
    {
        public Categorie Categorie { get; set; }

        public ICollection<Batiment> Batiments { get; set; }
    }
}
