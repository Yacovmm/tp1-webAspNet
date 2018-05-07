using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Domain;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController()
        {
            _context = new AppDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
           
            
            return View();
        }

        public ActionResult New()
        {

            return View("AmigoForm");
        }

        [HttpPost]
        public ActionResult Save(Amigo amigo)
        {
            if (amigo.Id == 0)
            {
                _context.Amigos.Add(amigo);
            }
            else
            {
                var amigoInDB = _context.Amigos.Single(x => x.Id == amigo.Id);

                amigoInDB.Name = amigo.Name;
                amigoInDB.LastName = amigo.LastName;
                amigoInDB.Email = amigo.Email;
                amigoInDB.Birthday = amigo.Birthday;
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}