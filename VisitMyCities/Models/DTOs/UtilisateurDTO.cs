using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class UtilisateurDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator Utilisateur(UtilisateurDTO dto) => dto.model;
        Utilisateur model { get; set; }

        // Constructeurs avec et sans paramètre
        public UtilisateurDTO()
        {
            model = new Utilisateur();
        }

        public UtilisateurDTO(Utilisateur utilisateur)
        {
            model = utilisateur;
        }


    }
}
