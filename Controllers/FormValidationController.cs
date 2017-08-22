using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using validatingFormSubmission.Models;

namespace validatingFormSubmission.Controllers
{
    public class FormValidationController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddUser(User model)
        {
            if(ModelState.IsValid)
            {
                return View("addUser");
            } else {
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }
        }
    }
}
