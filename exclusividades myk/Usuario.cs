using System;
using System.Collections.Generic;
using System.Text;

namespace exclusividades_myk
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public Usuario(string usuario, string contraseña, string rol)
        {
            NombreUsuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
