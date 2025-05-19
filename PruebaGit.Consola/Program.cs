using PruebaGit.Entidades;
using PruebaGit.Servicios;

namespace PruebaGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var servicio = new PersonaServicio();

            Console.WriteLine("Manejo de Personas");
            Console.WriteLine("1 - Agregar");
            Console.WriteLine("2 - Borrar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Listar");
            Console.WriteLine("Ingrese opción:");
            string? opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1": 
                    Console.WriteLine("Ingresar los datos de la persona:");
                    var datos = Console.ReadLine();
                    var nuevaPersona = new Persona();
                    
                    servicio.Agregar(nuevaPersona);
                    break;
                case "2":
                    Console.WriteLine("Ingresar id de la persona a borrar:");
                    var idBorrar = Console.ReadLine();
                    servicio.Borrar(idBorrar);
                    break;
                case "3":
                    Console.WriteLine("Ingresar id de la persona a editar:");
                    var idEditar =Console.ReadLine();
                    servicio.Editar(idEditar);
                    break;
                case "4":
                    Console.WriteLine("Lista de personas:");
                    Console.WriteLine($"{servicio.Listar()}");
                    break;

                default: Console.WriteLine("Ingresar una opcion");
                    break;
            }
        }

        
    }
}
