using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnakeEyesGame.Models;

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller
    {
        private SnakeEyes _snakeEyes;
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();
            return View(_snakeEyes);
        }
    }
}