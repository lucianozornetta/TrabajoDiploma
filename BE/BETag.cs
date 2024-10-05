using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETag
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
