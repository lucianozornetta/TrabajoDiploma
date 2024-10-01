using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEArea
    {

        public string Nombre { get; set; }
        public BEUsuario Responsable { get; set; }

        public List<BEUsuario> EmpleadosDelArea { get; set; }
    }
}
