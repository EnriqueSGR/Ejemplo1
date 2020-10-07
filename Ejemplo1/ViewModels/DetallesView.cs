using Ejemplo1.Models;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.ViewModels
{
    public class DetallesView
    {
        public String Titulo { get; set; }
        public String SubTitulo { get; set; }
        public Amigo amigo { get; set; }
    }
}
