using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class Ville
    {
        [Key]
        public int VilleId { get; set; }
        [Required]
        [Display(Name = "Ville")]
        public string NomVille { get; set; }

        [Display(Name = "Région")]
        public string NomRegion { get; set; }

        [Display(Name = "Département")]
        public int NumDepartement { get; set; }

        [Display(Name = "Nom Département")]
        public string NomDepartement { get; set; }
        public string Blason { get; set; }

        [Display(Name = "Maire")]
        public string NomMaire { get; set; }
        // Propriété de navigation
        public ICollection<Batiment> Batiments { get; set; }
    }
}
