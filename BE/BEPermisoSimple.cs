using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermisoSimple : BEPermiso
    {
        public override void AgregarHijo(BEPermiso permiso)
        {
            throw new NotImplementedException();
        }

        public override void EliminarHijo(BEPermiso permiso)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
