using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEInformeAbiertoCerrado
    {
        public string Area { get; set; }
        public int Abiertos { get; set; }
        public int Cerrados { get; set; }

        public int DentroSLA { get; set; }

        public int FueraSLA { get; set; }


        public BEInformeAbiertoCerrado()
        {
            this.Abiertos = 0;
            this.Cerrados = 0;
            this.DentroSLA = 0;
            this.FueraSLA = 0;
        }
    }
}
