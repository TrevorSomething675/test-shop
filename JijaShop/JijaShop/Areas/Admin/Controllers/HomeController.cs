﻿using Microsoft.AspNetCore.Mvc;

namespace JijaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class HomeController : Controller
    { 
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}