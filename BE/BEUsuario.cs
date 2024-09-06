using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuario:IUsuario
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public BEPermiso permiso { get; set; }
        public int DVH { get; set; }
        public override string ToString()
        {
            return Usuario;
        }
    }
    
}
