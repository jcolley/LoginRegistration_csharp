using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class LoginRegistrationController : Controller
    {
        private readonly DbConnector _dbConnector;

        public LoginRegistrationController(DbConnector connect)
        {
            _dbConnector = connect;
        }

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
                string q = $"INSERT INTO Users (first_name, last_name, age, email, password) VALUES('{model.FirstName}','{model.LastName}','{model.Age}','{model.Email}','{model.Password}')";
                _dbConnector.Query(q);

                return View("addUser");
            } else {
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }
        }
    }
}
