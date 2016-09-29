using APD.AGL.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace APD.AGL.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var service = new PeopleServices();
            var model = new AGL.Mvc.Models.AGLViewModel();            
            model.MalesCat = service.GetCatByGender("Male").Select(o => o.Name).OrderBy(str => str).ToList();
            model.FemalesCat = service.GetCatByGender("Female").Select(o => o.Name).OrderBy(str => str).ToList();
            return View(model);
        }
    }
}