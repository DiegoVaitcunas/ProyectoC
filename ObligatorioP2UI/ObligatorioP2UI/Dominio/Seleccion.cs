using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Seleccion : IComparable
    {
        public Seleccion()
        {

        }
        public Seleccion(Pais unPais)
        {
            this.unPais = unPais;
            this.jugadores = new List<Jugador>();
        }
        public void AgregarJugador(Jugador jugador)
        {
            this.jugadores.Add(jugador);
        }
        public List<Jugador> jugadores { get; set; }
        public Pais unPais { get; set; }

        #region validadores
        public void ValidarListaJugadores()
        {
            if (this.jugadores.Count <= 11)
            {
                throw new Exception("la lista de jugadores no puede ser menor a 11");
            }
        }
        #endregion
        public int CompareTo(object obj)
        {
            Seleccion s = (Seleccion)obj;
            return this.unPais.Nombre.CompareTo(s.unPais.Nombre);
        }
    }
}


      


