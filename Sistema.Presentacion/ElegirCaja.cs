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
    public partial class ElegirCaja : Form
    {
        string Nombre_Actual = "";
        string Clave_Actual = "";

        public ElegirCaja(string Nombre, string Clave)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Clave_Actual = Clave;
        }

        private void ElegirCaja_Load(object sender, EventArgs e)
        {
            cmb_Caja.Items.Add("Caja 1");
            cmb_Caja.Items.Add("Caja 2");
            cmb_Caja.Items.Add("Caja 3");
            cmb_Caja.Items.Add("Caja 4");

            cmb_Caja.DataSource = N_Caja.sp_Get_Cajas();
            cmb_Caja.ValueMember = "Caja";
            cmb_Caja.DisplayMember = "Caja";

           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string Elcaja = cmb_Caja.Text;



            if (Elcaja.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de Elegir Caja -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Elcaja);
                xd.Show();
                
            }



        }

        private void cmb_Caja_KeyPress(object sender, KeyPressEventArgs e)
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
