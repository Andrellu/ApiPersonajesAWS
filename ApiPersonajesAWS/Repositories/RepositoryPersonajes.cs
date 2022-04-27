using ApiPersonajesAWS.Data;
using ApiPersonajesAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPersonajesAWS.Repositories
{
    public class RepositoryPersonajes
    {
        private PersonajesContext context;

        public RepositoryPersonajes(PersonajesContext context)
        {
            this.context = context;
        }

        public List<Personaje> GetPersonajes()
        {
            return this.context.Personajes.ToList();
        }

        public Personaje FindPersonaje(int idPersonaje)
        {
            return this.context.Personajes.Where(x => x.IdPersonaje == idPersonaje).FirstOrDefault();
        }

        public void InsertPersonaje(int id, string nombre, string imagen)
        {
            Personaje personaje = new Personaje()
            {
                IdPersonaje = id,
                Nombre = nombre,
                Imagen = imagen
            };
            this.context.Personajes.Add(personaje);
            this.context.SaveChanges();
        }
    }
}
