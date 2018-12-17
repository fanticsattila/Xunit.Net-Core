using Microsoft.AspNetCore.Mvc;
using MockTest.Models;
using MockTest.Repositories;

namespace MockTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
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
                _customerRepository.Save(model);
            }
            return View();
        }
    }
}
