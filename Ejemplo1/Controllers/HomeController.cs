using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.Controllers
{
    public class HomeController:Controller
    {
        public JsonResult Index()
        {
            return Json(new { id = 2, nombre = "Pepito" });
        }
    }
}
