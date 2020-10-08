using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.Models
{
    public class MocikAmigoRepositorio : IAmigoAlmacen
    {
        private List<Amigo> amigosLista;

        public MocikAmigoRepositorio()
        {
            amigosLista = new List<Amigo>();

            amigosLista.Add(new Amigo() { Id = 1, Nombre = "Pedro", Ciudad = "Madrid", Email = "Pedro@mail.com" });
            amigosLista.Add(new Amigo() { Id = 2, Nombre = "Juan", Ciudad = "Toledo", Email = "Juan@mail.com" }); 
            amigosLista.Add(new Amigo() { Id = 3, Nombre = "Sara", Ciudad = "Cuenca", Email = "Sara@mail.com" });
        }

        public Amigo dameDatosAmigo(int Id)
        {
            return this.amigosLista.FirstOrDefault(e => e.Id == Id);
        }

        public List<Amigo> DameTodosLosAmigos()
        {
            return amigosLista;
        }
    }
}
