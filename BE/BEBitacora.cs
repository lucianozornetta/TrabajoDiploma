using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class BEBitacora : IBitacora
    {
        public int Index { get; set; }
        public DateTime Fecha { get; set; }
        public BitacoraTipo Tipo { get; set; }
        public string Usuario { get; set; }
        public string Mensaje { get; set; }
    }
}
