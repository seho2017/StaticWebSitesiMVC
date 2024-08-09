using personelmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace personelmvc.ViewModels
{
    public class DepartmanDetayViewModel
    {
        public Departman Departman { get; set; }
        public List<personel> personeller { get; set; }
    }
}