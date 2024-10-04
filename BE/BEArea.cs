using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEArea
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public BEUsuario Responsable { get; set; }

        public List<BEUsuario> EmpleadosDelArea { get; set; }

        public override string ToString()
        {
            if(this.Nombre != null)
            {
                return this.Nombre;
            }
            else
            {
                return this.ID.ToString();
            }
        }

        public BEArea()
        {
            this.EmpleadosDelArea = new List<BEUsuario>();
        }
        public BEArea(int a)
        {
            this.ID = a;
            this.EmpleadosDelArea = new List<BEUsuario>();
        }

    }
}
