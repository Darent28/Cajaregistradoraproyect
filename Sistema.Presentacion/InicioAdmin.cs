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
    public partial class InicioAdmin : Form
    {

        private string name = "";
        string Admin = "";

        public InicioAdmin(string Nombre)
        {
            InitializeComponent();
            this.name = Nombre;

        }



        private void InicioAdmin_Load(object sender, EventArgs e)
        {

            codigo.Clear();
            nud_Cantidad.ResetText();

            admin.Text = name;

            try
            {
                Dgv_rPuntoRe.DataSource = N_Producto.sp_Get_PuntoRe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_usurio_Click(object sender, EventArgs e)
        { 

            RegistroEmpleado who = new RegistroEmpleado(this.name);
            who.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login xd = new Login();
            xd.Show();
        }

        private void btn_verCajero_Click(object sender, EventArgs e)
        {

     
            VerCajero xd = new VerCajero(this.name);
            xd.Show();
            this.Hide();

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {

            Producto xd = new Producto(this.name);
            xd.Show();
            this.Hide();
        }

        private void btn_GesDep_Click(object sender, EventArgs e)
        {

            Departamento xd = new Departamento(this.name);
            xd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string codigo_ = codigo.Text;
            string cantidad_ = nud_Cantidad.Text;
            Admin = admin.Text;
            if (codigo_.CompareTo("") == 0 || cantidad_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan llenar datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Producto.sp_GestionarProduPu(codigo_, Admin, Convert.ToInt32(cantidad_));

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioAdmin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InicioAdmin_Load(sender, e);
                }

            }
        }

        private void Dgv_rPuntoRe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_rPuntoRe.RowCount < 1)
            {
                return;
            }
            else
            {
                codigo.Text = Dgv_rPuntoRe.CurrentRow.Cells[0].Value.ToString();
            }

        
        }

        private void btn_Cajas_Click(object sender, EventArgs e)
        {
            Caja xd = new Caja(this.name);
            xd.Show();
            this.Hide();
        }

        private void btn_rVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteVentas xd = new ReporteVentas(this.name);
            xd.Show();
        }

        private void btn_rCajero_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCajero xd = new ReporteCajero(this.name);
            xd.Show();
        }

        private void nud_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47))
            {
                MessageBox.Show("Solo numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {

        }
    }
}
