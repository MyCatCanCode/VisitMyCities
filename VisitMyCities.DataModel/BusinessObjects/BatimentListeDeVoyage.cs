using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class BatimentListeDeVoyage
    {
       
        public int BatimentId { get; set; }

        public Batiment Batiment { get; set; }

      
        public int IdListe { get; set; }

        public ListeDeVoyage ListeDeVoyage { get; set; }
    }
}
