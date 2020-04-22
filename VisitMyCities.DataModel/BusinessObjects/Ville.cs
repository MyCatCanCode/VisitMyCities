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
        public string NomVille { get; set; }
        public string NomRegion { get; set; }
        public int NumDepartement { get; set; }
        public string NomDepartement { get; set; }
        // Propriété de navigation
        public ICollection<Batiment> Batiments { get; set; }
    }
}
