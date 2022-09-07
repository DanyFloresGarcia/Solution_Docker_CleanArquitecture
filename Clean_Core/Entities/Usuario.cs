using System;

namespace Clean_Arqui.Core.Entities
{
    public class Usuario : Persona
    {
        public int usuario { get; set; }
        public string contrasena { get; set; }
        public Rol rol { get; set; }
    }
}
