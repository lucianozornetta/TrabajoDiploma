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
        public BEPermisoCompuesto() { }
        public BEPermisoCompuesto(int numero)
        {
            this.ID = numero;
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
