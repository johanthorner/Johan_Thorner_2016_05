﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanThorner_MVC_2016_05.Controllers
{
    public class SpriteController : Controller
    {
        // GET: Sprite
        public ActionResult Hexa()
        {
            return View();
        }
        public ActionResult Octa()
        {
            return View();
        }
    }
}