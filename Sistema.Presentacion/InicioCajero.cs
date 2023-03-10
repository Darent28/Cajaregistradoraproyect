using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Presentacion
{
    public partial class InicioCajero : Form
    {
        string Nombre_Actual = "";
        string Clave_Actual = "";
        string Numero_Pedidos = "";
        string Nombre_Caja = "";
        int numero = 0;

        string codigo_ = "";
        string totales = "";
        string producto_ = ""; 
        string Unimedi_ = "";
        string departamento_ = "";
        string preuni_ = "";
        string subtotal_ = "";
        string Departamento_ = "";
        string descuento_ = "";
        string total_ = "";
        string freedom = "";

        int Counter = 0;
     
        string cantidad_ = "";
        string PAGOS = "";
        string METODOS = "";

        public InicioCajero(string Nombre, string Clave, string Caja)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Clave_Actual = Clave;
            Nombre_Caja = Caja;
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            InicioCajero_Load(sender, e);
            this.Hide();
            InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        public void btn_anadir_Click(object sender, EventArgs e)
        {
            string codigo_ = CodigoV.Text;
            string producto_ = nProducto.Text;
            string cantidad_ = nud_Cantidad.Text;
            string cajero_ = Cajero.Text;

            double exisatencia_ = Int32.Parse(Dgv_Ventas.Rows[Dgv_Ventas.CurrentRow.Index].Cells["Existencia"].Value.ToString());

            totales = subtotal.Text;



            if (codigo_.CompareTo("") == 0 || producto_.CompareTo("") == 0 || cantidad_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (exisatencia_ < Int32.Parse(cantidad_))
                {
                    MessageBox.Show("No hay suficientes Productos en Existencia", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string[] totalremove = new string[] {"$"};
                    foreach (var c in totalremove)
                    {
                        totales = totales.Replace(c, string.Empty);
                    }
                   


                    string respuesta = N_Venta.sp_vender(codigo_, producto_, Int32.Parse(cantidad_), float.Parse(totales), "I");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Se ha añadido el producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicioCajero_Load(sender, e);
                        this.Hide();
                        InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
                        xd.Show();
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicioCajero_Load(sender, e);
                    }
                }


                //DataTable table = new DataTable();
                //table = N_Venta.sp_Carrito_Vali(codigo_);
                //if (table.Rows.Count == 0)  // Validacion, si ya Existe
                //{



                //}
                //else
                //{
                //    MessageBox.Show("Este producto ya esta añadido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }

        public void InicioCajero_Load(object sender, EventArgs e)
        {
            Cajero.Clear();
            Cajero.AppendText(Nombre_Actual);
            Caja.Clear();
            Caja.AppendText(Nombre_Caja);

            ClaveCa.Text = Clave_Actual;

            CodigoV.Clear();
            nProducto.Clear();
            txt_mostrar_total.ResetText();
            nud_Cantidad.ResetText();
            txt_Id.Clear();

            pago_.Text = "";
            metodo_.Text = "";

            pago_.Text = string.Format(PAGOS.ToString());
            metodo_.Text = string.Format(METODOS.ToString());

            Random rnd = new Random();
            numero = rnd.Next(100000, 1000000);
            string nuemroaStr = numero.ToString();
            txt_Id.AppendText(nuemroaStr);


            try
            {
                Dgv_Ventas.DataSource = N_Venta.sp_Get_Ventas();
                Dgv_VCarrito.DataSource = N_Venta.sp_Get_Vcarrito();


                float suma = 0;
                foreach (DataGridViewRow row in Dgv_VCarrito.Rows)
                {

                    if (row.Cells["Total a pagar"].Value != null &&
                        row.Cells["Codigo"].Value != null && row.Cells["Producto"].Value != null
                        && row.Cells["Cantidad"].Value != null && row.Cells["Unidad de medida"].Value != null
                        && row.Cells["Departamento"].Value != null && row.Cells["Descuento del producto"].Value != null
                        && row.Cells["Precio Unitario"].Value != null && row.Cells["Subtotal"].Value != null
                        && row.Cells["Total a pagar"].Value != null)



                    suma += (float)row.Cells["Total a pagar"].Value;
                    codigo_ = row.Cells["Codigo"].Value.ToString();
                    producto_ = row.Cells["Producto"].Value.ToString();
                    cantidad_ = row.Cells["Cantidad"].Value.ToString();
                    Unimedi_ = row.Cells["Unidad de medida"].Value.ToString();
                    departamento_ = row.Cells["Departamento"].Value.ToString();
                    descuento_ = row.Cells["Descuento del producto"].Value.ToString();
                    preuni_ = row.Cells["Precio Unitario"].Value.ToString();
                    subtotal_ = row.Cells["Subtotal"].Value.ToString();
                    total_ = row.Cells["Total a pagar"].Value.ToString();
                   

                }
            
                string totalsum = String.Format("${0:n}", suma);
                txt_mostrar_total.AppendText(totalsum);
                
     
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        public void PassPagoData(string pago, string metodo)
        {
            this.PAGOS = pago;
            this.METODOS = metodo;

        }

        private void btn_pagarcon_Click(object sender, EventArgs e)
        {
            if (Dgv_VCarrito.RowCount < 1)
            {
                MessageBox.Show("Carrito de compra vacio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string Total_ = txt_mostrar_total.Text;

                string[] totalremove = new string[] { "$" };
                foreach (var c in totalremove)
                {
                    Total_ = Total_.Replace(c, string.Empty);
                }

                this.Hide();
                FormaPago form = new FormaPago(Nombre_Actual, Clave_Actual, Nombre_Caja);
                form.PassSellData(float.Parse(Total_));
                form.ShowDialog();
            }

        }
        public void btn_vender_Click(object sender, EventArgs e)
        {

           
            //string  Pago = comboBox1.Text;
            string Numero_ = txt_Id.Text;
            string Total_ = txt_mostrar_total.Text;
            string Caja_ = Caja.Text;
            string Cajero_ = Cajero.Text;
            var creacion_ = Fecha.Text;
            var hora_ = Hora.Text;

            var creaciondate = fPago.Text;
            string clave_ = ClaveCa.Text;


           


            string[] totalremove = new string[] { "$" };
            foreach (var c in totalremove)
            {
                Total_ = Total_.Replace(c, string.Empty);
            }

            if (Dgv_VCarrito.RowCount < 1)
            {
                return;
            }
            else
            {


                string pagoins = pago_.Text;
                string metodoins = metodo_.Text;

                string respuesta = "";
                string respuesta2 = "";



                if (pagoins.CompareTo("") == 0 || metodoins.CompareTo("") == 0)
                {
                    MessageBox.Show("Falta agregar el tipo de pago", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    Document PDF = new Document(); //Creacion del documento PDF
                    Page page1 = PDF.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina
                    BackgroundArtifact bg = new BackgroundArtifact();
                    bg.BackgroundImage = File.OpenRead("Recibo.jpg");
                    page1.Artifacts.Add(bg);

                    string Idrecibos = Numero_;
                    TextFragment txtIdrecibo = new TextFragment(Idrecibos);
                    txtIdrecibo.Position = new Position(70, 665);
                    txtIdrecibo.TextState.FontSize = 15;
                    txtIdrecibo.TextState.Font = FontRepository.FindFont("Arial");
                    txtIdrecibo.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    string Cajero = Cajero_;
                    TextFragment txtcajero = new TextFragment(Cajero);
                    txtcajero.Position = new Position(225, 715);
                    txtcajero.TextState.FontSize = 15;
                    txtcajero.TextState.Font = FontRepository.FindFont("Arial");
                    txtcajero.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    string Clave = clave_;
                    TextFragment txtclave = new TextFragment(Clave);
                    txtclave.Position = new Position(260, 690);
                    txtclave.TextState.FontSize = 15;
                    txtclave.TextState.Font = FontRepository.FindFont("Arial");
                    txtclave.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    string Fecha = creacion_;
                    TextFragment txtfecha = new TextFragment(Fecha);
                    txtfecha.Position = new Position(455, 690);
                    txtfecha.TextState.FontSize = 15;
                    txtfecha.TextState.Font = FontRepository.FindFont("Arial");
                    txtfecha.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    string Hora = hora_;
                    TextFragment txthora = new TextFragment(Hora);
                    txthora.Position = new Position(455, 665);
                    txthora.TextState.FontSize = 15;
                    txthora.TextState.Font = FontRepository.FindFont("Arial");
                    txthora.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                    TextBuilder txtBuilder = new TextBuilder(page1);
                    txtBuilder.AppendText(txtIdrecibo);
                    txtBuilder.AppendText(txtcajero);
                    txtBuilder.AppendText(txtclave);
                    txtBuilder.AppendText(txtfecha);
                    txtBuilder.AppendText(txthora);
                    PDF.Save("Recibos\\Ticket de compra - " + Idrecibos + ".pdf");

                    //edit1
                    var fileRecibo = @"Recibos\\Ticket de compra - " + Idrecibos + ".pdf";
                    Document editPDF = new Document(fileRecibo);
                    Page pdfPage2 = (Page)editPDF.Pages[1];

                    string Metodopago = pagoins;
                    TextFragment txtpago = new TextFragment(Metodopago);
                    txtpago.Position = new Position(70, 200);
                    txtpago.TextState.FontSize = 14;
                    txtpago.TextState.Font = FontRepository.FindFont("Arial");
                    txtpago.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    string Caja = Caja_;
                    TextFragment txtcaja = new TextFragment(Caja);
                    txtcaja.Position = new Position(270, 140);
                    txtcaja.TextState.FontSize = 18;
                    txtcaja.TextState.Font = FontRepository.FindFont("Arial");
                    txtcaja.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    //altura total
                    string Total = "$" + Total_;
                    TextFragment txttotal = new TextFragment(Total);
                    txttotal.Position = new Position(495, 275);
                    txttotal.TextState.FontSize = 18;
                    txttotal.TextState.Font = FontRepository.FindFont("Arial");
                    txttotal.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder txtBuilderS = new TextBuilder(pdfPage2);
                    txtBuilderS.AppendText(txtpago);
                    txtBuilderS.AppendText(txtcaja);
                    txtBuilderS.AppendText(txttotal);
                    editPDF.Save("Recibos\\Ticket de compra - " + Idrecibos + ".pdf");


                    var fileRecibo2 = @"Recibos\\Ticket de compra - " + Idrecibos + ".pdf";
                    Document editPDF2 = new Document(fileRecibo2);
                    Page pdfPage3 = (Page)editPDF2.Pages[1];


                    DataTable table = new DataTable();
                    table = N_Venta.sp_Get_Vcarrito();
                    Numero_Pedidos = Convert.ToString(table.Rows.Count);//numero de Ordenes

                    int pos = 60;
                    for (int i = 0; i < int.Parse(Numero_Pedidos); i++)
                    {
                        string cantab = Convert.ToString(table.Rows[i][2]);
                        string preuni = Convert.ToString(table.Rows[i][6]);
                        string desc = Convert.ToString(table.Rows[i][5]);
                        string importe = Convert.ToString(table.Rows[i][8]);
                        string Um = Convert.ToString(table.Rows[i][3]);
                        string produc = Convert.ToString(table.Rows[i][1]);
                        string depa = Convert.ToString(table.Rows[i][4]);

                        string Cantidad = cantab;
                        TextFragment txtcantidad = new TextFragment(Cantidad);
                        txtcantidad.Position = new Position(60, 575 - (i * pos));
                        txtcantidad.TextState.FontSize = 12;
                        txtcantidad.TextState.Font = FontRepository.FindFont("Arial");
                        txtcantidad.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                        string PrecioUni = preuni;
                        TextFragment txtpreciouni = new TextFragment(PrecioUni);
                        txtpreciouni.Position = new Position(155, 575 - (i * pos));
                        txtpreciouni.TextState.FontSize = 12;
                        txtpreciouni.TextState.Font = FontRepository.FindFont("Arial");
                        txtpreciouni.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                        string Descuento = desc;
                        TextFragment txtdesc = new TextFragment(Descuento);
                        txtdesc.Position = new Position(300, 575 - (i * pos));
                        txtdesc.TextState.FontSize = 12;
                        txtdesc.TextState.Font = FontRepository.FindFont("Arial");
                        txtdesc.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                        string Importe = "$" + importe;
                        TextFragment txtimport = new TextFragment(Importe);
                        txtimport.Position = new Position(495, 575 - (i * pos));
                        txtimport.TextState.FontSize = 12;
                        txtimport.TextState.Font = FontRepository.FindFont("Arial");
                        txtimport.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                        string Producto = depa + "   |   " + produc + "   |   " + Um;
                        TextFragment txtpro = new TextFragment(Producto);
                        txtpro.Position = new Position(60, 600 - (i * pos));
                        txtpro.TextState.FontSize = 12;
                        txtpro.TextState.Font = FontRepository.FindFont("Arial");
                        txtpro.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                        TextBuilder txtBuilderT = new TextBuilder(pdfPage3);
                        txtBuilderT.AppendText(txtcantidad);
                        txtBuilderT.AppendText(txtpreciouni);
                        txtBuilderT.AppendText(txtdesc);
                        txtBuilderT.AppendText(txtimport);
                        txtBuilderT.AppendText(txtpro);

                    }
                    editPDF2.Save("Recibos\\Ticket de compra - " + Idrecibos.ToString() + ".pdf");



                    foreach (DataGridViewRow row in Dgv_VCarrito.Rows)
                    {

                        if (row.Cells["Codigo"].Value != null && row.Cells["Producto"].Value != null
                            && row.Cells["Cantidad"].Value != null && row.Cells["Unidad de medida"].Value != null
                            && row.Cells["Departamento"].Value != null && row.Cells["Descuento del producto"].Value != null
                            && row.Cells["Precio Unitario"].Value != null && row.Cells["Subtotal"].Value != null
                            && row.Cells["Total a pagar"].Value != null)

                            codigo_ = row.Cells["Codigo"].Value.ToString();
                        producto_ = row.Cells["Producto"].Value.ToString();
                        cantidad_ = row.Cells["Cantidad"].Value.ToString();
                        Unimedi_ = row.Cells["Unidad de medida"].Value.ToString();
                        departamento_ = row.Cells["Departamento"].Value.ToString();
                        descuento_ = row.Cells["Descuento del producto"].Value.ToString();
                        preuni_ = row.Cells["Precio Unitario"].Value.ToString();
                        subtotal_ = row.Cells["Subtotal"].Value.ToString();
                        total_ = row.Cells["Total a pagar"].Value.ToString();




                        respuesta2 = N_Recibos.sp_Recibo(Int32.Parse(Numero_), codigo_, Cajero_, Caja_, producto_, metodoins, departamento_, float.Parse(cantidad_), float.Parse(total_), float.Parse(Total_), DateTime.Parse(creaciondate));
                        respuesta = N_Venta.sp_vender(codigo_, producto_, float.Parse(cantidad_), float.Parse(total_), "U");


                    }

                    if (respuesta.Equals("OK") || respuesta2.Equals("OK"))
                    {
                        MessageBox.Show("Se a ejecutado la compra", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InicioCajero_Load(sender, e);
                        this.Hide();
                        InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
                        xd.Show();

                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicioCajero_Load(sender, e);
                    }


                }






            }

        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            codigo_ = CodigoV.Text;
            freedom = codigo_;
            producto_ = nProducto.Text;


            if (codigo_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Dgv_VCarrito.RowCount; i++)
                {
                    cantidad_ = Convert.ToString(Dgv_VCarrito.Rows[i].Cells[2].Value);
                    totales = Convert.ToString(Dgv_VCarrito.Rows[i].Cells[8].Value);

                }

              

                    DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el Cajero con el id " + "[" + freedom.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    string respuesta = N_Venta.sp_vender(codigo_, producto_, float.Parse(cantidad_), float.Parse(totales), "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Producto eliminado del carrito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InicioCajero_Load(sender, e);
                        this.Hide();
                        InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
                        xd.Show();
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicioCajero_Load(sender, e);
                    }
                }




            }
        }

        public void FechaActual_Tick(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Dgv_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoV.Text = Dgv_Ventas.CurrentRow.Cells[0].Value.ToString();
            nProducto.Text = Dgv_Ventas.CurrentRow.Cells[1].Value.ToString();
            subtotal.Text = Dgv_Ventas.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Devueltos xd = new Devueltos(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

            Login xd = new Login();
            xd.Show();
            this.Hide();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario xd = new Inventario(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaRecibo xd = new ConsultaRecibo(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_VCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_VCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Dgv_VCarrito.RowCount < 1)
            {
                return;
            }
            else
            {
                //Id.Text = Dgv_VCarrito.CurrentRow.Cells[0].Value.ToString();
                CodigoV.Text = Dgv_VCarrito.CurrentRow.Cells[0].Value.ToString();
                nProducto.Text = Dgv_VCarrito.CurrentRow.Cells[1].Value.ToString();
                nud_Cantidad.Text = Dgv_VCarrito.CurrentRow.Cells[3].Value.ToString();

            }

        }

        private void Busqueda_TextChanged(object sender, EventArgs e)
        {
            Dgv_Ventas.DataSource = N_Venta.sp_Busqueda_Ventas(Busqueda.Text, Busqueda.Text);
            string dato = Busqueda.Text;
            

            if (dato.CompareTo("") == 0)
            {
                InicioCajero_Load(sender, e);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateRecibo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fPago_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void nud_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <= 47))
            {
                MessageBox.Show("Solo numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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
