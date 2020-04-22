using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class DetailArchitectural
    {
        public int IdDetailArchi { get; set; }
        public string NomDetailArchi { get; set; }
        public string DescriptionDetailArchi { get; set; }
        // propriété de navigation
        public int IdBatiment { get; set; }
        public Batiment Batiment { get; set; }
        
    }
}
