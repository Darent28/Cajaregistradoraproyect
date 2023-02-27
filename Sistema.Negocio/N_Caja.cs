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
    public class N_Caja
    {

      

        public static DataTable sp_Get_Cajas()
        {
            D_Caja admin = new D_Caja();
            return admin.sp_Get_Cajas();
        }


        public static string sp_GestionarCajaInserto(string nombre, string Op)
        {
            D_Caja admin = new D_Caja();
            Caja Obj = new Caja();
            Obj.nombre = nombre;
            Obj.Op = Op;

            return admin.sp_GestionarCajas(Obj);
        }

        public static string sp_GestionarCajas(string id, string nombre, string Op)
        {
            D_Caja admin = new D_Caja();
            Caja Obj = new Caja();
            Obj.id = id;
            Obj.nombre = nombre;
            Obj.Op = Op;

            return admin.sp_GestionarCajas(Obj);
        }

    }


}
