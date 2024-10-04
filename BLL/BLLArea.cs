using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLArea
    {

        public bool CrearArea(BEArea area)
        {
           MPPArea mpparea = new MPPArea();
           return mpparea.CrearArea(area);
        }

        public List<BEArea> ListarAreas()
        {
            MPPArea mpparea = new MPPArea();
            return mpparea.ListarAreas();

        }

        public void ListarEmpleados(BEArea area)
        {
            MPPUsuario mppusuario = new MPPUsuario();
            List<BEUsuario> listausuarios = mppusuario.ListarUsuarios();
            foreach(BEUsuario usu in listausuarios)
            {
                if(usu.Area != null)
                {
                    if (usu.Area.ID == area.ID)
                    {
                        usu.Area = area;
                        area.EmpleadosDelArea.Add(usu);
                    }
                }
               
            }
        }

        public bool ValidarNombre(string nombre)
        {
            List<BEArea> ListaAreas = ListarAreas();
            foreach (BEArea area in ListaAreas)
            {
                if (area.Nombre == nombre)
                    return false;
            }
            return true;
        }
    }
}
