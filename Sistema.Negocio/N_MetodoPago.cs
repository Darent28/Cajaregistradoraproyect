using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_MetodoPago
    {
        public static string sp_GestionarMetodopago(string TipoPago, float cantidad, string Op)
        {
            D_MetodoPago admin = new D_MetodoPago();
            MetodoPago Obj = new MetodoPago();
            Obj.TipoPago = TipoPago;
            Obj.cantidad = cantidad;
            Obj.Op = Op;

            return admin.sp_GestionarMetodopago(Obj);
        }

        public static string sp_GestionarMetodopagoEliminar(string TipoPago, string Op)
        {
            D_MetodoPago admin = new D_MetodoPago();
            MetodoPago Obj = new MetodoPago();
            Obj.TipoPago = TipoPago;
            Obj.Op = Op;

            return admin.sp_GestionarMetodopago(Obj);
        }

        public static DataTable sp_Get_Metodopago()
        {
            D_MetodoPago admin = new D_MetodoPago();
            return admin.sp_Get_Metodopago();
        }

        public static string sp_Delete_Metodopago()
        {
            D_MetodoPago admin = new D_MetodoPago();
            MetodoPago Obj = new MetodoPago();

            return admin.sp_Delete_Metodopago(Obj);
        }
    }
}
