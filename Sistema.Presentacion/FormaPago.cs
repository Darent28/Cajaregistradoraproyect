using System;
using Sistema.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FormaPago : Form
    {
       

        string Nombre_Actual = "";
        string Clave_Actual = "";
        string Nombre_Caja = "";

        float Total = 0;
        float Restante = 0;
        double Subtotal;
        double Descuento;

        public FormaPago(string Nombre, string Clave, string Caja)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Clave_Actual = Clave;
            Nombre_Caja = Caja;

            cbox_mPago.Items.Add("Tarjeta de debito");
            cbox_mPago.Items.Add("Tarjeta de credito");
            cbox_mPago.Items.Add("Cheque");
            cbox_mPago.Items.Add("Vales de despensa");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void PassSellData(float total)
        {
            this.Total = total;

        }

        public void FormaPago_Load(object sender, EventArgs e)
        {

            cantidadP.ResetText();
            Restante = Total;
            
     


            _total.Text = string.Format("${0:n}", float.Parse(Total.ToString()));
                Restante = Total;
            _restante.Text = string.Format("{0:n}", float.Parse(Restante.ToString()));

            try
            {
                dgPagos.DataSource = N_MetodoPago.sp_Get_Metodopago();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        public void Refresh1()
        {
            string restate = "";
            if (dgPagos.RowCount > 0)
            {
                for (int i = 0; i < dgPagos.RowCount; i++)
                {
                    restate = Convert.ToString(dgPagos.Rows[i].Cells[1].Value);
                    Restante = Restante - float.Parse(restate);
                }
                
            }
            _restante.Text = string.Format("{0:n}", float.Parse(Restante.ToString()));

        }

        public void Refresh2()
        {
            string sumate = "";
            if (dgPagos.RowCount > 0)
            {
                for (int i = 0; i < dgPagos.RowCount; i++)
                {
                    sumate = Convert.ToString(dgPagos.Rows[i].Cells[1].Value);
                    Restante = Restante + float.Parse(sumate);
                }
               
            }
            _restante.Text = string.Format("{0:n}", float.Parse(Restante.ToString()));
        }

        private void cantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47))
            {
                MessageBox.Show("Solo numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

       
        private void aceptar_Click(object sender, EventArgs e)
        {
            if (dgPagos.RowCount < 1)
            {
                MessageBox.Show("No ha regristado ningun pago", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_restante.Text == "0.00")
                {
                    string pagos = "";
                    string metodo = "";
                    for (int i = 0; i < dgPagos.RowCount; i++)
                    {
                        string valor = Convert.ToString(dgPagos.Rows[i].Cells[1].Value);
                        string tipo = Convert.ToString(dgPagos.Rows[i].Cells[0].Value);
                        pagos = pagos + tipo + ": $" + valor.ToString() + "  \n";
                        metodo = metodo + "| " + tipo + " | ";


                    }
                    string respuesta = "";
                    respuesta = N_MetodoPago.sp_Delete_Metodopago();

                    this.Hide();
                    InicioCajero form = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
                    form.PassPagoData(pagos, metodo);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Queda total a pagar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                   
                }

            }
           
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string Tipo_ = cbox_mPago.Text;
            string can_ = cantidadP.Text;

            if (can_.CompareTo("") == 0 || Tipo_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (float.Parse(can_) > Restante)
                {
                    MessageBox.Show("Monto mayor a la cantidad a pagar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (cbox_mPago.SelectedItem != null)
                    {
                        cbox_mPago.Items.Remove(cbox_mPago.SelectedItem.ToString());
                    }

                    string respuesta = N_MetodoPago.sp_GestionarMetodopago(Tipo_, float.Parse(can_), "I");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Cantidad de pago hecha", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormaPago_Load(sender, e);
                        Refresh1();
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormaPago_Load(sender, e);
                    }
                }
                    


                
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            respuesta = N_MetodoPago.sp_Delete_Metodopago();

            this.Hide();
            InicioCajero form = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
            form.ShowDialog();
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            string metodo_ = tbmetodo.Text;
            if (metodo_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
             

                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar este tipo de pago " + "[" + metodo_.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    string respuesta = N_MetodoPago.sp_GestionarMetodopagoEliminar(metodo_, "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Tipo de pago eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormaPago_Load(sender, e);
                        Refresh2();
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormaPago_Load(sender, e);
                    }
                }

            }
        }

        private void dgPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPagos.RowCount < 1)
            {
                return;
            }
            else
            {
                tbmetodo.Text = dgPagos.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void cbox_mPago_KeyPress(object sender, KeyPressEventArgs e)
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
