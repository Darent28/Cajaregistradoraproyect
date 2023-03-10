using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{

   
    public class D_Caja
    {

        public DataTable sp_Get_Cajas()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Cajas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }





        public string sp_GestionarCajas(Caja Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_GestionarCajas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id", SqlDbType.Int).Value = Obj.id;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@Op", SqlDbType.Char).Value = Obj.Op;
                SqlCon.Open();
                //Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return Rpta;
        }

    }
}
