using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuarioHistorico
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public int DVH { get; set; }
        public override string ToString()
        {
            return Usuario;
        }
    }
}
