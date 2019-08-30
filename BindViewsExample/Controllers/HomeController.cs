using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using BindViewsExample.Models;

namespace BindViewsExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Restaurant restaurant = new Restaurant()
            {
                Id = 1,
                Name = "Fragoleto 1",
                Address = "Rua das Delicias, 1000",
                Review = 3,
                Open = true,
                Speciality = "Frango Frito"
            };
            return View();
        }

        [Route("Home/Display")]
        public IActionResult AnotherWayToDisplay()
        {
            Restaurant restaurant = new Restaurant()
            {
                Id = 1,
                Name = "Fragoleto 2",
                Address = "Rua das Delicias, 2000",
                Review = 5,
                Open = true,
                Speciality = "Frango Grelhado"
            };
            return View();
        }
    }
}