using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class BEIdioma
    {
        public string nombre { get; set; }

        public int ID { get; set; }

        public List<BETraduccion> ListaTraducciones { get; set; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
