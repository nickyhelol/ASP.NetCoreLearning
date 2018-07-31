﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infrastructure;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptimeService;

        public HomeController(UptimeService uptimeService)
            => this.uptimeService = uptimeService;

        public ViewResult Index() =>
            View(new Dictionary<string, string>
            {
                ["message"] = "This is the Index action",
                ["Uptime"] = $"{uptimeService.Uptime}ms"
            });
    }
}