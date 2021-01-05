using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models
{
    public class BatimentViewModel
    {
        public Batiment Batiment { get; set; }
        public ICollection<DetailArchitectural> Details { get; set; }
    }
}
