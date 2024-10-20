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

       public int carga { get; set; }
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
            this.carga = 0;
        }

        public BEUsuario(string a)
        {
            this.Usuario = a;
            this.Aptitudes = new List<BETag>();
            this.carga = 0;
        }
        public void CalcularCarga(List<BEOrdenDeTrabajo> ListaWO)
        {
           
            int a = 0;
            foreach (BEOrdenDeTrabajo orden in ListaWO)
            {
                if (orden.EmpleadoAsignado.Usuario == this.Usuario)
                {
                    this.carga += DevolverCostoWO(orden);
                }
            }

           
        }
        public int DevolverCostoWO(BEOrdenDeTrabajo WO)
        {
            if (WO != null)
            {
                if(WO.Estado != "Cerrado")
                {
                    if (WO is BEOrdenTrabajoBaja)
                    {
                        return 2;
                    }
                    if (WO is BEOrdenTrabajoModerado)
                    {
                        return 4;
                    }
                    if (WO is BEOrdenTrabajoCritico)
                    {
                        return 6;
                    }
                }

                return -1;
            }
            else
            {
                return -1;
            }
        }
    }
    
}
