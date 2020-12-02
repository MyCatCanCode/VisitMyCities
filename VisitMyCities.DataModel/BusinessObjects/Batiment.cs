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

        [Display(Name = "Bâtiment")]
        public string NomBatiment { get; set; }

        [Display(Name = "Adresse")]
        public string Adresse { get; set; }
        public string URLPhoto { get; set; }

        [Display(Name = "Type")]
        public string TypeBatiment { get; set; }

        [Display(Name = "Description")]
        public string DescriptionBatiment { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        [Display(Name = "Monument historique")]
        public bool? MonumentHistorique { get; set; }

        [Display(Name = "Construction")]
        public string DateConstruction { get; set; }
        // propriétés de navigation
        public ICollection<DetailArchitectural> Details { get; set; }
        public int VilleId { get; set; }
        public Ville Ville { get; set; }
        public ICollection<BatimentListeDeVoyage> BatimentsListeDeVoyage { get; set; }
        public ICollection<UtilisateurBatiment> BatimentsEvalues { get; set; }



    }
}
