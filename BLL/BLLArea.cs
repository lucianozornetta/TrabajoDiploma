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
    }
}
