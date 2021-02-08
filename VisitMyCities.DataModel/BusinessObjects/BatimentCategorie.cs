using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class BatimentCategorie
    {
        public int BatimentId { get; set; }

        public Batiment Batiment { get; set; }

      
        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }
    }
}
