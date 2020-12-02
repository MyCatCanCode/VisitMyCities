using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class Utilisateur : IdentityUser
    {
        [PersonalData]
        public string NomUtilisateur { get; set; }

        [PersonalData]
        public string PrenomUtilisateur { get; set; }

        [PersonalData]
        [Required]
        [EmailAddress]
        public override string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Se souvenir de moi ?")]
        public bool SeSouvenir { get; set; }

        public ICollection<ListeDeVoyage> ListesDeVoyage { get; set; }

        public ICollection<UtilisateurBatiment> BatimentsEvalues { get; set; }


    }
}
