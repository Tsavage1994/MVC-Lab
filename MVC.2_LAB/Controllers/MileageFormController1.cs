using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC._2_LAB.Models.MileageFormController1;

namespace MVC._2_LAB.Controllers
{
    public class MileageFormController1 : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult FormResults(FormResultsViewModel model)
        {
            return View(model);
        }
    }
}