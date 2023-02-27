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
    public partial class ReporteCajero : Form
    {

        string Nombre_Actual = "";

        public ReporteCajero(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void ReporteCajero_Load(object sender, EventArgs e)
        {
            cb_Departamento.DataSource = N_Recibos.sp_Departamento();
            cb_Departamento.ValueMember = "departamento";
            cb_Departamento.DisplayMember = "departamento";

            cb_Cajero.DataSource = N_Recibos.sp_Cajero();
            cb_Cajero.ValueMember = "Cajero";
            cb_Cajero.DisplayMember = "Cajero";


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_rCajero.DataSource = N_Recibos.sp_GetReporteCajero(cb_Cajero.Text, cb_Departamento.Text, dtp_fInicio.Text, dtp_fFin.Text);
            string depa = cb_Departamento.Text;
            string caje = cb_Cajero.Text;
            string FI = dtp_fInicio.Text;
            string FF = dtp_fFin.Text;

            if (depa.CompareTo("") == 0 || caje.CompareTo("") == 0 || FI.CompareTo("") == 0 || FF.CompareTo("") == 0)
            {
                ReporteCajero_Load(sender, e);
            }


        }

        private void btn_buscartodas_Click(object sender, EventArgs e)
        {

            Dgv_rCajero.DataSource = N_Recibos.sp_GetReporteCajeroTodos(dtp_fInicio.Text, dtp_fFin.Text);

            string FI = dtp_fInicio.Text;
            string FF = dtp_fFin.Text;

            ReporteCajero_Load(sender, e);
        }

        private void cb_Cajero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 00 && e.KeyChar <= 255))
            {
                MessageBox.Show("No escribir en este campo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

        private void ReporteCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 00 && e.KeyChar <= 255))
            {
                MessageBox.Show("No escribir en este campo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

        private void cb_Cajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 00 && e.KeyChar <= 255))
            {
                MessageBox.Show("No escribir en este campo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

    }
}
