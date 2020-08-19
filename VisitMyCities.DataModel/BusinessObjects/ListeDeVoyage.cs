using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class ListeDeVoyage
    {
        public int IdListe { get; set; }
        public string TitreListe { get; set; }
        public Ville Ville { get; set; }
        public ICollection<Batiment> Batiments { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
