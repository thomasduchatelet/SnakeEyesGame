using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnakeEyesGame.Extensions;
using SnakeEyesGame.Models;

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller
    {
        private SnakeEyes _snakeEyes;
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();
            HttpContext.Session.SetObject("SnakeEyes", _snakeEyes);
            return View(_snakeEyes);
        }
        public IActionResult Play()
        {
            _snakeEyes = HttpContext.Session.GetObject<SnakeEyes>("SnakeEyes");
            _snakeEyes.Play();
            HttpContext.Session.SetObject("SnakeEyes", _snakeEyes);
            return View("Index", _snakeEyes);
        }
    }
}