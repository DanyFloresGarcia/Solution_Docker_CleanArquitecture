using System;

namespace Clean_Arqui.Core.Entities
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
