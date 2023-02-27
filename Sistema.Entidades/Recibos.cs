using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Recibos
    {
        public int IDr { get; set; }
        public int IdRecibo { get; set; }
        public string codigo { get; set; }
        public string Cajero { get; set; }
        public string caja { get; set; }
        public string produc { get; set; }
        public string forma_pago { get; set; }
        public string departamento { get; set; }
        public float cantidad { get; set; }
        public float subtotal { get; set; }
        public float total { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string Op { get; set; }
    }
}
