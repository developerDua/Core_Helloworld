using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_helloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_helloWorld.Controllers
{
    public class HomeController : Controller
    {
        public readonly IPersonDetail _personDetailRepo;

        public HomeController(IPersonDetail personDetail)
        {
            _personDetailRepo = personDetail;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonDetail model)
        {
            _personDetailRepo.AddDetail(model);
            return View(model);
        }
    }
}
