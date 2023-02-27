using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class MetodoPago
    {
        public string id { get; set; }
        public string TipoPago { get; set; }
        public float cantidad { get; set; }
        public string Op { get; set; }
    }
}
