using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario(string email,string password, string nombre, string apellido)
        {
            this.Email = email;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Password = password;
        }
        public Usuario() { }
    }
}
