using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Producto
    {
        public string codigo { get; set; }
        public string registered_by { get; set; }
        public string departamento { get; set; }
        public string descripcion { get; set; }
        public float precio_unitario { get; set; }
        public string unidad_de_medida { get; set; }
        public float costo { get; set; }
        public int existencia { get; set; }
        public string punto_de_reorden { get; set; }
        public string Op { get; set; }
    }
}
