using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class UtilisateurVille
    {
        public int VilleId { get; set; }
        public Ville Ville { get; set; }
        public string UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int NombreEtoiles { get; set; }
        public string Commentaire { get; set; }
    }
}
