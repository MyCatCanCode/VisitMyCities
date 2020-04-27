using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{

    //Modification de test
    //Modification 2
    public class Batiment
    {
        [Key]
        public int BatimentId { get; set; }
        [Required]
        public string NomBatiment { get; set; }
        public string Adresse { get; set; }
        public string URLPhoto { get; set; }
        [Required]
        public string TypeBatiment { get; set; }
        public string DescriptionBatiment { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool MonumentHistorique { get; set; }
        public DateTime DateConstruction { get; set; }
        // propriétés de navigation
        public ICollection<DetailArchitectural> Details { get; set; }
        public int VilleId { get; set; }
        public Ville Ville { get; set; }
    }
}
