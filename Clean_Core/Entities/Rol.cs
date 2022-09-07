using System;

namespace Clean_Arqui.Core.Entities
{
    public class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaCreacion { get; set; }
        public Usuario usuarioCreador { get; set; }
        public bool Activo { get; set; }
    }
}
