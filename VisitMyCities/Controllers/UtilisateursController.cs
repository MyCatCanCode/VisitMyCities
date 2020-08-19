using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisitMyCities.DataModel.BusinessObjects;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.Controllers
{
    public class UtilisateursController : Controller
    {
        private IRepository _repository;
        public UtilisateursController (IRepository repo)
        {
            _repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Utilisateur utilisateur)
        {
            return View();
        }
    }
}
