using PruebaGit.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaGit.Datos
{
    public class PersonaRepositorio
    {
        private List<Persona> personas = null!;
        public PersonaRepositorio()
        {
            personas = new List<Persona>();
            LeerDatos();
        }
        private void LeerDatos()
        {

            personas.Add(new Persona { Id = 1, Nombre = "Ana", Apellido = "García" });
            personas.Add(new Persona { Id = 2, Nombre = "Marcos", Apellido = "López" });
            personas.Add(new Persona { Id = 3, Nombre = "Sofía", Apellido = "Martínez" });
            personas.Add(new Persona { Id = 4, Nombre = "Pedro", Apellido = "González" });
            personas.Add(new Persona { Id = 5, Nombre = "Laura", Apellido = "Rodríguez" });
        }

        public List<Persona> ListarPersonas()
        {
            //foreach (Persona persona in personas)
            //{
            //    return persona.ToString();
            //}
            return personas;
           
        }

        public bool Editar(string idEditar)
        {
            throw new NotImplementedException();
        }

        private bool Existe(Persona persona)
        {
            return personas.Contains(persona);
        }

        public bool Agregar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(string idBorrar)
        {
            throw new NotImplementedException();
        }
    }
}
