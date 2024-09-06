using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FiltroBitacora
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string usuario { get; set; }

        public BitacoraTipo tipo { get; set; }


    }
}
