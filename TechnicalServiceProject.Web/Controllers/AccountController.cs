﻿using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceProject.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register() 
        { 
            return View(); 
        }


    }
}