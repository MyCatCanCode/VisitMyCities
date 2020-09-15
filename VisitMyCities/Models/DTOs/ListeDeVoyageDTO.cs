using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class ListeDeVoyageDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator ListeDeVoyage(ListeDeVoyageDTO dto) => dto.model;
        ListeDeVoyage model { get; set; }

        // Constructeurs avec et sans paramètre
        public ListeDeVoyageDTO()
        {
            model = new ListeDeVoyage();
        }

        public ListeDeVoyageDTO(ListeDeVoyage liste)
        {
            model = liste;
        }

        // Propriétés
        public int IdListe
        {
            get { return model.IdListe; }
            set { model.IdListe = value; }
        }

        public string TitreListe
        {
            get { return model.TitreListe; }
            set { model.TitreListe = value; }
        }
        public Ville Ville
        {
            get { return model.Ville; }
            set { model.Ville = value; }
        }
    }
}
