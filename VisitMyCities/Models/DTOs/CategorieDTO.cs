using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class CategorieDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator Categorie(CategorieDTO dto) => dto.model;
        Categorie model { get; set; }

        // Constructeurs avec et sans paramètre
        public CategorieDTO()
        {
            model = new Categorie();
        }

        public CategorieDTO(Categorie cat)
        {
            model = cat;
        }

        // Propriétés
        public int CategorieId
        {
            get { return model.CategorieId; }
            set { model.CategorieId = value; }
        }

        public string NomBatiment
        {
            get { return model.NomCategorie; }
            set { model.NomCategorie = value; }
        }
    }
}
