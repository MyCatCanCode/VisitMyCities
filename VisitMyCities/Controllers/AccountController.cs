using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Utilisateur> userManager;
        private readonly SignInManager<Utilisateur> loginManager;

        // Initialisation de l’état via des injections de dépendance.
        public AccountController(VisitMyCitiesContext dc, UserManager<Utilisateur> userManager, SignInManager<Utilisateur> loginManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
        }

        // Permet d’accéder aux fonctionnalités de l’application. Tous les utilisateurs (authentifiés et anonymes) peuvent y accéder.
        [AllowAnonymous]
        public IActionResult Index()
        {
            return this.View();
        }

        // Permet d’accéder au formulaire d’ajout d’un utilisateur.
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // Permet d’ajouter un utilisateur.
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(string username, string email, string password, string firstName, string lastName)
        {
            IActionResult result;

            var user = new Utilisateur()
            {
                PrenomUtilisateur = firstName,
                NomUtilisateur = lastName,
                UserName = username,
                Email = email
            };

            IdentityResult resultCreate = await this.userManager.CreateAsync(user, password);

            if (resultCreate.Succeeded)
            {
                result = this.RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Message = "Erreur lors de l'inscription";
                result = this.RedirectToAction(nameof(Register));
            }

            return result;
        }

        // Permet d’accéder au formulaire de connexion.
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return this.View();
        }

        // Permet à un utilisateur de s’authentifier.
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string username, string password, string rememberme)
        {
            IActionResult result;

            var resultLogin = await this.loginManager.PasswordSignInAsync(username, password, rememberme == "on", false);

            result = this.RedirectToAction(resultLogin.Succeeded ? nameof(AccessAllowed) : nameof(AccessDenied));

            return result;
        }

        // Permet à un utilisateur de se déconnecter.
        public IActionResult Logout()
        {
            this.loginManager.SignOutAsync();

            return RedirectToAction(nameof(Index));
        }

        // Permet d’afficher une vue indiquant l’échec de l’authentification.
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return this.View();
        }

        // Permet d’afficher une vue indiquant la réussite de l’authentification.    
        public IActionResult AccessAllowed()
        {
            return this.View();
        }
    }
}
