using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLBitacora
    {
        MPPBitacora mpbitacora;
        public bool GuardarBitacora(BEBitacora bitacora)
        {
            mpbitacora = new MPPBitacora();
            return mpbitacora.GuardarBitacora(bitacora);
        }
        public List<BEBitacora> ListarBitacoras(FiltroBitacora f)
        {
            mpbitacora = new MPPBitacora();
            return mpbitacora.ListarBitacoras(f);
        }

    }
}
