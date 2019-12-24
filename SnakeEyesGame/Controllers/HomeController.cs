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
        private int _highscore = 0;
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();
            ViewBag.Highscore = _highscore;
            HttpContext.Session.SetObject("Highscore", _highscore);
            HttpContext.Session.SetObject("SnakeEyes", _snakeEyes);
            return View(_snakeEyes);
        }
        public IActionResult Play()
        {
            _snakeEyes = HttpContext.Session.GetObject<SnakeEyes>("SnakeEyes");
            _highscore = HttpContext.Session.GetObject<int>("Highscore");
            _snakeEyes.Play();
            _highscore = _snakeEyes.Total > _highscore ? _snakeEyes.Total : _highscore;
            ViewBag.Highscore = _highscore;
            HttpContext.Session.SetObject("Highscore", _highscore);
            HttpContext.Session.SetObject("SnakeEyes", _snakeEyes);
            return View("Index", _snakeEyes);
        }
    }
}