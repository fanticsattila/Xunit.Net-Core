using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MockTest.Models;
using MockTest.Repositories;

namespace MockTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View(new CustomerModel() { FirstName = "", LastName = "" });
        }

        [HttpPost]
        public IActionResult Index(CustomerModel model)
        {
            if(ModelState.IsValid)
            {
                var repository = new CustomerRepository(_configuration);
                repository.Save(model);
            }
            return View();
        }
    }
}
