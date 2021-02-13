using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UKKomGazEnergo.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductRepository productRepository;

        public SearchController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(string query)
        {
            var products = productRepository.GetAllByTitle(query);
            return View(products);
        }
    }
}
