using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPArea
    {
        Acceso acceso;
        Hashtable hasdatos;
        public bool CrearArea(BEArea area)
        {
            acceso = new Acceso();
            hasdatos = new Hashtable();

            string consultasql = "S_CrearArea";

            hasdatos.Add("@Nombre", area.Nombre);
            hasdatos.Add("@Responsable", area.Responsable.Usuario);

            return acceso.Escribir(consultasql, hasdatos);
        }
    }
}
