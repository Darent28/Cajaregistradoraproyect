using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Venta
    {
        public int Id_v { get; set; }
        public string codigo { get; set; }
        public string nombreP { get; set; }
        public float Cantidad { get; set; }
        public float Total { get; set; }
        public string Op { get; set; }
    }
}
