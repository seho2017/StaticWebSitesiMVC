using personelmvc.Models;
using personelmvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace personelmvc.Controllers
{
    public class DepartmanController : Controller
    {
      public ActionResult Detay(int id)
        {
            var departman = new Departman() { id = id, Ad = "bilgi işlem" };
            var personeller = new List<personel>()
            {
                new personel(){ad="personel1"},
                new personel(){ad="personel2"},
                new personel(){ad="personel3"},
            };
            var model = new DepartmanDetayViewModel()
            {
                Departman = departman,
                personeller = personeller
            };

         return View(model);
        }
      
       
    }
}