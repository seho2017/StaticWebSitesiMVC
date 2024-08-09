using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace personelmvc.Controllers
{
    public class PersonelController : Controller
    {
        // GET: personel
        public ActionResult Index()
        {
            return Content("personel anasayfa");
        }
      
    }
}