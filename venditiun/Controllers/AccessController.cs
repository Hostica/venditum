﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace venditiun.Controllers
{
    public class AccessController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}