﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UKKomGazEnergo.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly ProductService productService;

        public SearchController(ProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index(string query)
        {
            var products = productService.GetAllByQuery (query);
            return View(products);
        }
    }
}
