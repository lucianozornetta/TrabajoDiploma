using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BE
{
    public class BEInformeEmpleado
    {
        public string Usuario { get; set; }
        public int CasosAbiertos { get; set; } 

        public int CasosCerrados { get; set; }

        public int DentroDeSLA { get; set; }
        public int FueraDeSLA { get; set; }
       
    }
}
