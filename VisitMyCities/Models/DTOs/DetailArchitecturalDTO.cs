using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class DetailArchitecturalDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator DetailArchitectural(DetailArchitecturalDTO dto) => dto.model;
        DetailArchitectural model { get; set; }

        // Constructeurs avec et sans paramètre
        public DetailArchitecturalDTO()
        {
            model = new DetailArchitectural();
        }

        public DetailArchitecturalDTO(DetailArchitectural detail)
        {
            model = detail;
        }

        // Propriétés
        public int DetailId
        {
            get { return model.DetailId; }
            set { model.DetailId = value; }
        }

        public string NomDetail
        {
            get { return model.NomDetail; }
            set { model.NomDetail = value; }
        }
        public string DescriptionDetail
        {
            get { return model.DescriptionDetail; }
            set { model.DescriptionDetail = value; }
        }       
    }
}
