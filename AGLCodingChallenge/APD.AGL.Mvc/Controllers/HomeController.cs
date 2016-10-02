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

        protected IPeopleServices _service;

        public HomeController(IPeopleServices service)
        {
            _service = service;
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = new AGL.Mvc.Models.AGLViewModel();            
            model.MalesCat = _service.GetCatByGender("Male").Select(o => o.Name).OrderBy(str => str).ToList();
            model.FemalesCat = _service.GetCatByGender("Female").Select(o => o.Name).OrderBy(str => str).ToList();
            return View(model);
        }
    }
}