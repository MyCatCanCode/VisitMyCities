using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class UtilisateurBatiment
    {
        public int BatimentId { get; set; }
        public Batiment Batiment { get; set; }
        public string UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int NombreEtoiles { get; set; }
        public string Commentaire { get; set; }
    }

}
