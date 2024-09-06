using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLRepositorioIdioma
    {
        MPPRepositorioIdioma mp;
        public bool GuardarIdioma(BEIdioma idioma)
        {
            mp = new MPPRepositorioIdioma();
            return mp.GuardarIdioma(idioma);
        }
        public bool EliminarIdioma(BEIdioma idioma)
        {
            return true;
        }
        public bool ModificarIdioma(BEIdioma idioma , List<BETraduccion> listatraducciones)
        {
            return true;
        }
        public List<BEIdioma> ListarIdiomas()
        {
            mp = new MPPRepositorioIdioma();
            return mp.ListarIdioma();
        }
        public bool GuardarPalabra(string palabra)
        {
            mp = new MPPRepositorioIdioma();
            return mp.GuardarPalabra(palabra);
        }
        public Dictionary<int, string> ListarPalabras()
        {
            mp = new MPPRepositorioIdioma();
            return mp.ListarPalabras();
        }
        public bool ModificarIdioma(BEIdioma idioma)
        {
            mp = new MPPRepositorioIdioma();
            return mp.ModificarIdioma(idioma);
        }

        public List<BETraduccion> ListarTraducciones(BEIdioma idioma)
        {
            mp = new MPPRepositorioIdioma();
            return mp.ListarTraducciones(idioma);
        }
    }
}
