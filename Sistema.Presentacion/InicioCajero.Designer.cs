namespace Sistema.Presentacion
{
    partial class InicioCajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_devoluciones = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.CodigoV = new System.Windows.Forms.TextBox();
            this.Caja = new System.Windows.Forms.TextBox();
            this.FechaActual = new System.Windows.Forms.Timer(this.components);
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nProducto = new System.Windows.Forms.TextBox();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Cajero = new System.Windows.Forms.TextBox();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_mostrar_total = new System.Windows.Forms.TextBox();
            this.Dgv_VCarrito = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.ClaveCa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.pagarcon = new System.Windows.Forms.Button();
            this.metodo_ = new System.Windows.Forms.TextBox();
            this.pago_ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_consulta.Location = new System.Drawing.Point(30, 322);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(139, 27);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consulta de Recibos";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_inventario.Location = new System.Drawing.Point(30, 285);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(139, 27);
            this.btn_inventario.TabIndex = 2;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_devoluciones
            // 
            this.btn_devoluciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_devoluciones.Location = new System.Drawing.Point(30, 355);
            this.btn_devoluciones.Name = "btn_devoluciones";
            this.btn_devoluciones.Size = new System.Drawing.Size(139, 27);
            this.btn_devoluciones.TabIndex = 3;
            this.btn_devoluciones.Text = "Devoluciones";
            this.btn_devoluciones.UseVisualStyleBackColor = false;
            this.btn_devoluciones.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cerrar.Location = new System.Drawing.Point(30, 607);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(328, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cajero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Caja:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Location = new System.Drawing.Point(20, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 28;
            this.label.Text = "Fecha:";
            // 
            // CodigoV
            // 
            this.CodigoV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CodigoV.Location = new System.Drawing.Point(514, 282);
            this.CodigoV.Name = "CodigoV";
            this.CodigoV.ReadOnly = true;
            this.CodigoV.Size = new System.Drawing.Size(305, 20);
            this.CodigoV.TabIndex = 29;
            // 
            // Caja
            // 
            this.Caja.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Caja.Location = new System.Drawing.Point(64, 83);
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Size = new System.Drawing.Size(94, 20);
            this.Caja.TabIndex = 29;
            // 
            // FechaActual
            // 
            this.FechaActual.Enabled = true;
            this.FechaActual.Tick += new System.EventHandler(this.FechaActual_Tick);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(64, 113);
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Size = new System.Drawing.Size(134, 20);
            this.Fecha.TabIndex = 29;
            this.Fecha.TextChanged += new System.EventHandler(this.Hora_TextChanged);
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.AllowUserToAddRows = false;
            this.Dgv_Ventas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ventas.Location = new System.Drawing.Point(332, 50);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.Size = new System.Drawing.Size(850, 217);
            this.Dgv_Ventas.TabIndex = 30;
            this.Dgv_Ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Ventas_CellClick);
            this.Dgv_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Ventas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(586, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Producto:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(207, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // nProducto
            // 
            this.nProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nProducto.Location = new System.Drawing.Point(645, 308);
            this.nProducto.Name = "nProducto";
            this.nProducto.ReadOnly = true;
            this.nProducto.Size = new System.Drawing.Size(174, 20);
            this.nProducto.TabIndex = 29;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nud_Cantidad.Location = new System.Drawing.Point(274, 170);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(53, 20);
            this.nud_Cantidad.TabIndex = 31;
            this.nud_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Cantidad_KeyPress);
            // 
            // Cajero
            // 
            this.Cajero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cajero.Location = new System.Drawing.Point(64, 50);
            this.Cajero.Name = "Cajero";
            this.Cajero.ReadOnly = true;
            this.Cajero.Size = new System.Drawing.Size(134, 20);
            this.Cajero.TabIndex = 29;
            // 
            // btn_anadir
            // 
            this.btn_anadir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_anadir.Location = new System.Drawing.Point(246, 205);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(81, 27);
            this.btn_anadir.TabIndex = 4;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = false;
            this.btn_anadir.Click += new System.EventHandler(this.btn_anadir_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_vender.Location = new System.Drawing.Point(322, 594);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(120, 27);
            this.btn_vender.TabIndex = 4;
            this.btn_vender.Text = "Confirmar";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Busqueda.Location = new System.Drawing.Point(900, 282);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(277, 20);
            this.Busqueda.TabIndex = 29;
            this.Busqueda.TextChanged += new System.EventHandler(this.Busqueda_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(465, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Codigo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(851, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Buscar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(897, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "(Busqueda por codigo o nombre de producto)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Id.Location = new System.Drawing.Point(342, 380);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 33;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(329, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Numero de compra";
            this.label11.Click += new System.EventHandler(this.label5_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(976, 632);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 163;
            this.label20.Text = "Super Total:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txt_mostrar_total
            // 
            this.txt_mostrar_total.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_mostrar_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mostrar_total.Location = new System.Drawing.Point(1057, 629);
            this.txt_mostrar_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mostrar_total.Name = "txt_mostrar_total";
            this.txt_mostrar_total.ReadOnly = true;
            this.txt_mostrar_total.Size = new System.Drawing.Size(119, 20);
            this.txt_mostrar_total.TabIndex = 162;
            // 
            // Dgv_VCarrito
            // 
            this.Dgv_VCarrito.AllowUserToAddRows = false;
            this.Dgv_VCarrito.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_VCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_VCarrito.Location = new System.Drawing.Point(448, 364);
            this.Dgv_VCarrito.Name = "Dgv_VCarrito";
            this.Dgv_VCarrito.Size = new System.Drawing.Size(734, 257);
            this.Dgv_VCarrito.TabIndex = 30;
            this.Dgv_VCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_VCarrito_CellClick);
            this.Dgv_VCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_VCarrito_CellContentClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpiar.Location = new System.Drawing.Point(246, 239);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(81, 27);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // ClaveCa
            // 
            this.ClaveCa.AutoSize = true;
            this.ClaveCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClaveCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveCa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClaveCa.Location = new System.Drawing.Point(61, 34);
            this.ClaveCa.Name = "ClaveCa";
            this.ClaveCa.Size = new System.Drawing.Size(75, 13);
            this.ClaveCa.TabIndex = 165;
            this.ClaveCa.Text = "ClaveCajero";
            this.ClaveCa.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(443, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Comprar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(332, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // fPago
            // 
            this.fPago.Location = new System.Drawing.Point(535, 632);
            this.fPago.Name = "fPago";
            this.fPago.Size = new System.Drawing.Size(200, 20);
            this.fPago.TabIndex = 166;
            this.fPago.ValueChanged += new System.EventHandler(this.fPago_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(437, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de pago:";
            this.label4.Click += new System.EventHandler(this.label5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(27, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Hora:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(64, 139);
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Size = new System.Drawing.Size(94, 20);
            this.Hora.TabIndex = 29;
            this.Hora.TextChanged += new System.EventHandler(this.Hora_TextChanged);
            // 
            // subtotal
            // 
            this.subtotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subtotal.Location = new System.Drawing.Point(514, 308);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(66, 20);
            this.subtotal.TabIndex = 29;
            // 
            // pagarcon
            // 
            this.pagarcon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagarcon.Location = new System.Drawing.Point(322, 561);
            this.pagarcon.Name = "pagarcon";
            this.pagarcon.Size = new System.Drawing.Size(120, 27);
            this.pagarcon.TabIndex = 4;
            this.pagarcon.Text = "Pagar con";
            this.pagarcon.UseVisualStyleBackColor = false;
            this.pagarcon.Click += new System.EventHandler(this.btn_pagarcon_Click);
            // 
            // metodo_
            // 
            this.metodo_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metodo_.Location = new System.Drawing.Point(246, 533);
            this.metodo_.Multiline = true;
            this.metodo_.Name = "metodo_";
            this.metodo_.ReadOnly = true;
            this.metodo_.Size = new System.Drawing.Size(196, 22);
            this.metodo_.TabIndex = 33;
            this.metodo_.Visible = false;
            this.metodo_.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // pago_
            // 
            this.pago_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pago_.Location = new System.Drawing.Point(246, 505);
            this.pago_.Multiline = true;
            this.pago_.Name = "pago_";
            this.pago_.ReadOnly = true;
            this.pago_.Size = new System.Drawing.Size(196, 22);
            this.pago_.TabIndex = 33;
            this.pago_.Visible = false;
            this.pago_.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // InicioCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1193, 666);
            this.Controls.Add(this.fPago);
            this.Controls.Add(this.ClaveCa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_mostrar_total);
            this.Controls.Add(this.pago_);
            this.Controls.Add(this.metodo_);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.Dgv_VCarrito);
            this.Controls.Add(this.Dgv_Ventas);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.nProducto);
            this.Controls.Add(this.Cajero);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CodigoV);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagarcon);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_anadir);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_devoluciones);
            this.Name = "InicioCajero";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.InicioCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_devoluciones;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox CodigoV;
        public System.Windows.Forms.TextBox Caja;
        private System.Windows.Forms.Timer FechaActual;
        private System.Windows.Forms.DataGridView Dgv_Ventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nProducto;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.TextBox Busqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txt_mostrar_total;
        private System.Windows.Forms.DataGridView Dgv_VCarrito;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Fecha;
        public System.Windows.Forms.TextBox Cajero;
        public System.Windows.Forms.Label ClaveCa;
        private System.Windows.Forms.DateTimePicker fPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Button pagarcon;
        private System.Windows.Forms.TextBox metodo_;
        private System.Windows.Forms.TextBox pago_;
    }
}