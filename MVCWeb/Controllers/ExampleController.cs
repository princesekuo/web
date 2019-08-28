using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWeb.Models;

namespace MVCWeb.Controllers {
    public class ExampleController : Controller {

        public IActionResult Container () {
            return View ();
        }

        public IActionResult Grid () {
            return View ();
        }
        public IActionResult Content () {
            return View ();
        }
        public IActionResult Table () {
            return View ();
        }

        public IActionResult Figure () {
            return View ();
        }

        public IActionResult FigureRWD () {
            return View ();
        }

        public IActionResult Alerts () {
            return View ();
        }
        public IActionResult Badges () {
            return View ();
        }

        /// <summary>
        ///  卡片式顯示
        /// </summary>
        /// <returns></returns>
        public IActionResult Cards () {
            return View ();
        }

        public IActionResult Forms () {
            return View ();
        }

    }
}