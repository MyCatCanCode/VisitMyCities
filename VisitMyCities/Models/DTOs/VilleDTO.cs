using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class VilleDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator Ville(VilleDTO dto) => dto.model;
        Ville model { get; set; }

        // Constructeurs avec et sans paramètre
        public VilleDTO()
        {
            model = new Ville();
        }

        public VilleDTO(Ville ville)
        {
            model = ville;
        }

        // Propriétés
        public int VilleId
        {
            get { return model.VilleId; }
            set { model.VilleId = value; }
        }

        public string NomVille
        {
            get { return model.NomVille; }
            set { model.NomVille = value; }
        }
        public string NomRegion
        {
            get { return model.NomRegion; }
            set { model.NomRegion = value; }
        }
        public int NumDepartement
        {
            get { return model.NumDepartement; }
            set { model.NumDepartement = value; }
        }
        public string NomDepartement
        {
            get { return model.NomDepartement; }
            set { model.NomDepartement = value; }
        }
    }
}
