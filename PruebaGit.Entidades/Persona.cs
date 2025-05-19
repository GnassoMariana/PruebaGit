namespace PruebaGit.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; }=null!;

        //public Persona(int id, string nombre, string apellido)
        //{
        //    //Id = id;
        //    //Nombre = nombre;
        //    //Apellido = apellido;
        //}
        public Persona()
        {

        }

        public override string ToString()
        {
            return $"{Id} - {Apellido},{Nombre}";
        }
    }
}
