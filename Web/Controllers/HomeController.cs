using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BL.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOwner _owner;
        public HomeController(IOwner owner)
        {
            this._owner = owner;
        }
        public IActionResult Index()
        {
            var data = _owner.Get();

            return View(data); ;
        }


        public IActionResult About()
        {
            return View();
        }
    }
}
