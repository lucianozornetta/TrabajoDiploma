using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEPermiso
    {
        public string Nombre { get; set; }
        
        public int ID { get; set; }

        public bool EsPadre { get; set; }

        public List<BEPermiso> PermisosHijos  = new List<BEPermiso> { };


        public abstract void EliminarHijo(BEPermiso permiso);




        public abstract void AgregarHijo(BEPermiso permiso);
        
        
        


    }
}
