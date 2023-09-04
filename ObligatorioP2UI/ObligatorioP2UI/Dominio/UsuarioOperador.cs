using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class UsuarioOperador : UsuarioPeriodista
    {
        public UsuarioOperador(string nombre, string password, string email, string apellido, DateTime fecha) : base(email, password, nombre, apellido)
        {
            this.Fecha = fecha;
        }
        DateTime Fecha { get; set; }
    }
}
