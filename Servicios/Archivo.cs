using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Archivo
    {
        public string Nombre { get; set; }
        public string Extension { get; set; }

        public byte[] DatosArchivo { get; set; }

        public  BEDetalleWO detalle { get; set; }
    }
}
