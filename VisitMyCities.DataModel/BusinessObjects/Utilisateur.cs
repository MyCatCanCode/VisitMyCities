using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
    public class Utilisateur : IdentityUser
    {
        public string NomUtilisateur { get; set; }

        public string PrenomUtilisateur { get; set; }
        [Required]
        [EmailAddress]
        public override string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Se souvenir de moi ?")]
        public bool SeSouvenir { get; set; }

        public ICollection<ListeDeVoyage> ListesDeVoyage { get; set; }
    }
}
