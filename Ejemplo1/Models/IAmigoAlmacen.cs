using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.Models
{
    public interface IAmigoAlmacen
    {
        Amigo dameDatosAmigo(int Id);
        List<Amigo> DameTodosLosAmigos();
    }
}
