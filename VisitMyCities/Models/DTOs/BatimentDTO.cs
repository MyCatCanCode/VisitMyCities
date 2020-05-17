using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.Models.DTOs
{
    public class BatimentDTO
    {
        // Surcharge de l'opérateur de conversion explicite
        public static explicit operator Batiment(BatimentDTO dto) => dto.model;
        Batiment model { get; set; }

        // Constructeurs avec et sans paramètre
        public BatimentDTO()
        {
            model = new Batiment();
        }

        public BatimentDTO(Batiment bat)
        {
            model = bat;
        }

        // Propriétés
        public int BatimentId
        {
            get { return model.BatimentId; }
            set { model.BatimentId = value; }
        }

        public string NomBatiment
        {
            get { return model.NomBatiment; }
            set { model.NomBatiment = value; }
        }
        public string Adresse
        {
            get { return model.Adresse; }
            set { model.Adresse = value; }
        }
        public string URLPhoto
        {
            get { return model.URLPhoto; }
            set { model.URLPhoto = value; }
        }
        public string TypeBatiment
        {
            get { return model.TypeBatiment; }
            set { model.TypeBatiment = value; }
        }
        public string DescriptionBatiment
        {
            get { return model.DescriptionBatiment; }
            set { model.DescriptionBatiment = value; }
        }
        public double Longitude
        {
            get { return model.Longitude; }
            set { model.Longitude = value; }
        }
        public double Latitude
        {
            get { return model.Latitude; }
            set { model.Latitude = value; }
        }
        public bool MonumentHistorique
        {
            get { return model.MonumentHistorique; }
            set { model.MonumentHistorique = value; }
        }
        public DateTime DateConstruction
        {
            get { return model.DateConstruction; }
            set { model.DateConstruction = value; }
        }      

    }
}
