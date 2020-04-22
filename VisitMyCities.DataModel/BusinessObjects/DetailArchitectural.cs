using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class DetailArchitectural
    {
        [Key]
        public int DetailId { get; set; }
        public string NomDetail { get; set; }
        public string DescriptionDetail { get; set; }
        // propriété de navigation
        public int BatimentId { get; set; }
        public Batiment Batiment { get; set; }
        
    }
}
