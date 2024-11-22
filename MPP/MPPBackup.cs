using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace MPP
{
    public class MPPBackup
    {
        private readonly Acceso acceso;

        public MPPBackup()
        {
            acceso = new Acceso();
        }

        public bool GuardarBackup(string ruta)
        {
            return acceso.CrearBackup(ruta);
        }

        public bool RestaurarBackup(string ruta)
        {
            return acceso.RestaurarDesdeBackup(ruta);
        }
    }
}
