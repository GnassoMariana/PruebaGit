using PruebaGit.Datos;
using PruebaGit.Entidades;

namespace PruebaGit.Servicios
{
    public class PersonaServicio
    {
        private readonly PersonaRepositorio? personaRepositorio;
        public PersonaServicio()
        {
            personaRepositorio = new PersonaRepositorio();
        }

        public object Agregar(Persona persona)
        {
            return personaRepositorio!.Agregar(persona);
        }

        public bool Borrar(string idBorrar)
        {
            return personaRepositorio!.Borrar(idBorrar);
        }

        public bool Editar(string? idEditar)
        {
            return personaRepositorio!.Editar(idEditar);
        }

        public object Listar()
        {
            return personaRepositorio!.ListarPersonas();
        }
    }
}
