using System;

namespace Dominio
{
    //Periodista, tiene herencia de Persona.
    public class UsuarioPeriodista : Usuario
    {
        #region Constructor
        //Creamos la clase y realizamos su respectivo constructor
        public UsuarioPeriodista(string nombre,string password, string email, string apellido) : base(email, password, nombre, apellido) 
        {
            this.ValidarCamposVacios();
            this.ValidarMail();
            this.ValidarPassword();
        }
        public static int generateId()
        {
            ContadorId++;   //Generando el autonumerico
            return ContadorId;
        }
        #endregion

        //Atributos de Periodista.
        public int Id { get; set; } = generateId();
        public static int ContadorId { get; set; } = 0;

        #region Validadores
        //Validacion de contraseña que pide en la letra.
        public void ValidarPassword()
        {
            if (this.Password.Length < 8)
            {
                throw new Exception("La contraseña debe ser mayor a 8 caracteres");
            }
        }
        //Validacion de mail que pide en la letra.
        public void ValidarCamposVacios()
        {
            if (this.Nombre =="" || this.Password == "" || this.Email == "")
            {
                throw new Exception("Ningun campo puede estar vacio");
            }
        }
        public void ValidarMail()
        {
            int validar = this.Email.IndexOf("@");
            if (validar == -1 || validar == this.Email.Length-1 || validar == 0)
            {
                throw new Exception("El Email es incorrecto");
            }
        }
        #endregion
        //Metodo ToString para imprimir en pantalla lo solicitado.
        public override string ToString()
        {
            return $"Codigo de de identificacion: {this.Id} \n Nombre: {this.Nombre + ' ' + this.Apellido} \n Email: {this.Email} \n";
        }


    }
}

