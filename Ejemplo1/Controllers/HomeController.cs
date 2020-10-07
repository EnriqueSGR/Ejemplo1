using Ejemplo1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.Controllers
{
    public class HomeController:Controller
    {
        private IAmigoAlmacen amigoAlmacen;
        
        public HomeController(IAmigoAlmacen AmigoAlmacen)
        {
            amigoAlmacen = AmigoAlmacen;
        }

        //public string Index()
        //{
        //    return amigoAlmacen.dameDatosAmigo(1).Email;
        //}

        //public JsonResult Details()
        //{
        //    Amigo modelo = amigoAlmacen.dameDatosAmigo(1);
        //    return Json(modelo);
        //}


        public ViewResult Index()
        {
            var modelo = amigoAlmacen.DameTodosLosAmigos();
            return View(modelo);
        }

        public ViewResult Details()
        {
            Amigo amigo = amigoAlmacen.dameDatosAmigo(2);

            ViewData["Cabecera"] = "LISTA AMIGOS";
            ViewData["Amigo"] = amigo;
            ViewBag.Titulo = "LISTA AMIGOS VIEWBAG";
            ViewBag.Amigo = amigo;
            return View(amigo);
        }
    }
}
