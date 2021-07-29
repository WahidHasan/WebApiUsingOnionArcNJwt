using Microsoft.AspNetCore.Mvc;
using OA_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicStructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IProductRepo _repo;

        public HomeController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }
    }
}
