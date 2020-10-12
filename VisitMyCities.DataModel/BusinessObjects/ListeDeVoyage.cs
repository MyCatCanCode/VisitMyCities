using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class ListeDeVoyage
    {
        [Key]
        public int IdListe { get; set; }
        public string TitreListe { get; set; }
        public int VilleId { get; set; }
        public Ville Ville { get; set; }
        public string URLBlason { get; set; }
        public ICollection<BatimentListeDeVoyage> BatimentsListeDeVoyage { get; set; }
        public Utilisateur Utilisateur { get; set; }

        
    }
}
