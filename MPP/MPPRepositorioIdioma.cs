using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MPP
{
    public class MPPRepositorioIdioma
    {
        Acceso acceso;
        Hashtable hasdatos;
        public bool GuardarIdioma(BEIdioma idioma)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_CrearIdioma";
            
            hasdatos.Add("@Nombre",idioma.nombre);
            return acceso.Escribir(consultasql, hasdatos);
            
        }

        public List<BEIdioma> ListarIdioma()
        {
            acceso = new Acceso();
            string consultasql = "S_ListarIdiomas";
            List<BEIdioma> idiomas = new List<BEIdioma>();
            DataTable grilla = acceso.Leer(consultasql, null);            
            foreach(DataRow row in grilla.Rows)
            {
                BEIdioma idioma = new BEIdioma();
                idioma.ID = Convert.ToInt32(row["Id_Idioma"].ToString());
                idioma.nombre = row["Nombre"].ToString();
 
                idiomas.Add(idioma);
            }
            return idiomas;
        }

        public bool GuardarPalabra(string palabra)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();
            string consultasql = "S_GuardarPalabra";
            hasdatos.Add("@tag", palabra);
            return acceso.Escribir(consultasql, hasdatos);
        }

        public Dictionary<int, string> ListarPalabras()
        {
            acceso = new Acceso();
            string consultasql = "S_ListarPalabras";
            Dictionary<int, string> palabras = new Dictionary<int, string>();
            DataTable grilla = acceso.Leer(consultasql, null);
            foreach (DataRow row in grilla.Rows)
            {
                string palabra = row["Tag"].ToString();
                int j = Convert.ToInt32(row["Id"].ToString());
                palabras.Add(j ,palabra);

               
            }
            return palabras;
        }

        public bool ModificarIdioma(BEIdioma idioma)
        {
            acceso = new Acceso();
            Dictionary<int, string> dic = ListarPalabras();
            string consultasql = "S_ModificarIdioma";
            foreach(BETraduccion t in idioma.ListaTraducciones)
            {
                hasdatos = new Hashtable();
                hasdatos.Add("@IdPalabra", ObtenerIDPalabra(t.tag , dic));
                hasdatos.Add("@IdIdioma", idioma.ID);
                hasdatos.Add("@Texto", t.Texto);
                acceso.Escribir(consultasql, hasdatos);
            }
            return true;
        }

        public int ObtenerIDPalabra(string tag , Dictionary<int,string> diccionario)
        {
           foreach(int ID in diccionario.Keys)
           {
                if(tag == diccionario[ID])
                {
                    return ID;
                }
           }
           
                return 1;
            
        }

        public List<BETraduccion> ListarTraducciones(BEIdioma idioma)
        {
            acceso = new Acceso();
            string consultasql = "S_ListarTraducciones";
            List<BETraduccion> traducciones = new List<BETraduccion>();
            hasdatos = new Hashtable();
            hasdatos.Add("@Idioma", idioma.ID);
            DataTable grilla = acceso.Leer(consultasql, hasdatos);
            foreach (DataRow row in grilla.Rows)
            {
                BETraduccion traduccion = new BETraduccion();
                traduccion.id = Convert.ToInt32(row["TraduccionId"].ToString());
                traduccion.Texto = row["Traduccion"].ToString();
                traduccion.tag = row["Palabra"].ToString();

                traducciones.Add(traduccion);
            }
            return traducciones;
        }
    }
}
