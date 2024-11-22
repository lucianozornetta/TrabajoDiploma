using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;

namespace BLL
{
    public class BLLBackups
    {
        public bool CrearBackup(string ruta)
        {
            MPPBackup mPPBackup = new MPPBackup();
            return mPPBackup.GuardarBackup(ruta);
        }
        public bool RestoreBackup(string ruta)
        {
            MPPBackup mPPBackup = new MPPBackup();
            return mPPBackup.RestaurarBackup(ruta);
        }

    }
}
