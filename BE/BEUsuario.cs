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

       
        public BEPermiso Permiso { get; set; }

        public BEArea Area { get; set; }
        public int DVH { get; set; }

        public List<BETag> Aptitudes { get; set; }  

        public override string ToString()
        {
            return Usuario;
        }
        public BEUsuario()
        {
            this.Aptitudes = new List<BETag>();
        }

        public BEUsuario(string a)
        {
            this.Usuario = a;
            this.Aptitudes = new List<BETag>();
        }
    }
    
}
