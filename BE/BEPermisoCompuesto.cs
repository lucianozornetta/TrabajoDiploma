using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermisoCompuesto : BEPermiso
    {
        public override void AgregarHijo(BEPermiso permiso)
        {
            PermisosHijos.Add(permiso);
        }

        public override void EliminarHijo(BEPermiso permiso)
        {
            PermisosHijos.Remove(permiso);
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
