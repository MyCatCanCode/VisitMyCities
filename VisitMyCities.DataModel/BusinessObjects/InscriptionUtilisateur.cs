using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VisitMyCities.DataModel.BusinessObjects
{
     public class InscriptionUtilisateur
     {       
            public string Nom { get; set; }
            public string Prenom { get; set; }
            [Required(ErrorMessage = "L'adresse mail est obligatiore !")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "Le mot de passe est obligatoire !")]
            [DataType(DataType.Password)]
            public string MotDePasse { get; set; }

            [DataType(DataType.Password)]
            [Compare("MotDePasse", ErrorMessage = "Le mot de passe et la confirmation ne correspondent pas.")]
            public string ConfirmationMotDePasse { get; set; }       
     }
}
