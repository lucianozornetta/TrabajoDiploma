using BE;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Sesion : IObservable
    {
        private static Sesion _sesion;

        private BEUsuario Usu { get; set; }
        private DateTime FechaInicio { get; set; }

        private BEIdioma Idioma { get; set; }

        public List<IObserver> Lista { get; set; }

        
        private Sesion() {
            Lista = new List<IObserver>();
        }
               

        public static void Login(BEUsuario user)
        {
            try
            {
                if (_sesion == null)
                {
                    _sesion = new Sesion();
                    _sesion.Usu = user;
                    _sesion.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Sesion getinstace()
        {
            if(_sesion == null)
            {
                throw new Exception("No Inicio Sesion");
            }          
            
            return _sesion;
        }

        public static void Logout()
        {
            try
            {
                _sesion = null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BEUsuario ObtenerUsername()
        {
            try
            {
                return _sesion.Usu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  void AgregarObservador(IObserver observer)
        {
            _sesion.Lista.Add(observer);
        }

        public  void EliminarObservador(IObserver observer)
        {
            _sesion.Lista.Remove(observer);
        }

        public  void NotificarObservadores()
        {
            foreach(IObserver o in _sesion.Lista)
            {
                o.Update(_sesion.Idioma.ID);
            }
        }
        public void CambioDeEstado(BEIdioma idioma)
        {
            _sesion.Idioma = idioma;
            NotificarObservadores();
        }


    }
}
