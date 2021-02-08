using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        public string NomCategorie { get; set; }
        public ICollection<BatimentCategorie> BatimentsCategories { get; set; }
    }
}
