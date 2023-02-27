using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class Caja : Form
    {

        string Nombre_Actual = "";
        public Caja(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }

        private void Caja_Load(object sender, EventArgs e)
        {

            idDepa.Clear();
            Cajas.Clear();
            Registeredby.Clear();
            Registeredby.AppendText(Nombre_Actual);

            try
            {
                Dgv_rDepartamento.DataSource = N_Caja.sp_Get_Cajas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
          
            string NomCompleto_ = Cajas.Text;


            if (NomCompleto_.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar el nombre del Caja -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Caja.sp_GestionarCajaInserto( NomCompleto_, "I");
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Caja_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Caja_Load(sender, e);
                }

            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Caja_Load(sender, e);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string id_ = idDepa.Text;
            string NomCompleto_ = Cajas.Text;
            if (id_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan Datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Caja.sp_GestionarCajas(id_, NomCompleto_, "U");


                if (respuesta.Equals("OK"))
                {

                    MessageBox.Show("Datos Actualizados c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Caja_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Caja_Load(sender, e);
                }
            }

        }

   

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void Dgv_rDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cajas.Text = Dgv_rDepartamento.CurrentRow.Cells[1].Value.ToString();
            idDepa.Text = Dgv_rDepartamento.CurrentRow.Cells[0].Value.ToString();
        }

        private void Dgv_rDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_bajalogica_Click(object sender, EventArgs e)
        {
            string id_ = idDepa.Text;
            string NomCompleto_ = Cajas.Text;
            if (id_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan Datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Caja.sp_GestionarCajas(id_, NomCompleto_, "B");


                if (respuesta.Equals("OK"))
                {

                    MessageBox.Show("Eliminación logica hecha", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Caja_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Caja_Load(sender, e);
                }
            }

        }
    }
}



   

       
       

        
