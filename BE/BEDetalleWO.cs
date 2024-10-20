using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEDetalleWO
    {
        private int ID { get; set; }
        public DateTime FechaDetalle { get; set; } = DateTime.Now;
        public string Detalle { get; set; }
        public bool TieneArchivo { get; set; } = false;

        public  BEUsuario Usuario { get; set; }

        public void ObtenerID(int iD)
        {
            this.ID = iD;
        }
        public int DevolverID()
        {
            return this.ID;
        }
    }
}
