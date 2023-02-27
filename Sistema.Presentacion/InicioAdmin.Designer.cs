namespace Sistema.Presentacion
{
    partial class InicioAdmin
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
            this.btn_usurio = new System.Windows.Forms.Button();
            this.btn_verCajero = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_GesDep = new System.Windows.Forms.Button();
            this.Dgv_rPuntoRe = new System.Windows.Forms.DataGridView();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_caja = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_rCajero = new System.Windows.Forms.Button();
            this.btn_rVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rPuntoRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_usurio
            // 
            this.btn_usurio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_usurio.Location = new System.Drawing.Point(12, 24);
            this.btn_usurio.Name = "btn_usurio";
            this.btn_usurio.Size = new System.Drawing.Size(139, 27);
            this.btn_usurio.TabIndex = 0;
            this.btn_usurio.Text = "Agregar Cajero";
            this.btn_usurio.UseVisualStyleBackColor = false;
            this.btn_usurio.Click += new System.EventHandler(this.btn_usurio_Click);
            // 
            // btn_verCajero
            // 
            this.btn_verCajero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_verCajero.Location = new System.Drawing.Point(12, 65);
            this.btn_verCajero.Name = "btn_verCajero";
            this.btn_verCajero.Size = new System.Drawing.Size(139, 28);
            this.btn_verCajero.TabIndex = 0;
            this.btn_verCajero.Text = "Gestionar Cajeros";
            this.btn_verCajero.UseVisualStyleBackColor = false;
            this.btn_verCajero.Click += new System.EventHandler(this.btn_verCajero_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_productos.Location = new System.Drawing.Point(12, 150);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(139, 27);
            this.btn_productos.TabIndex = 0;
            this.btn_productos.Text = "Gestionar Productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_GesDep
            // 
            this.btn_GesDep.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_GesDep.Location = new System.Drawing.Point(12, 108);
            this.btn_GesDep.Name = "btn_GesDep";
            this.btn_GesDep.Size = new System.Drawing.Size(139, 27);
            this.btn_GesDep.TabIndex = 0;
            this.btn_GesDep.Text = "Gestionar Departamento";
            this.btn_GesDep.UseVisualStyleBackColor = false;
            this.btn_GesDep.Click += new System.EventHandler(this.btn_GesDep_Click);
            // 
            // Dgv_rPuntoRe
            // 
            this.Dgv_rPuntoRe.AllowUserToAddRows = false;
            this.Dgv_rPuntoRe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_rPuntoRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rPuntoRe.Location = new System.Drawing.Point(190, 60);
            this.Dgv_rPuntoRe.Name = "Dgv_rPuntoRe";
            this.Dgv_rPuntoRe.Size = new System.Drawing.Size(536, 245);
            this.Dgv_rPuntoRe.TabIndex = 25;
            this.Dgv_rPuntoRe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rPuntoRe_CellClick);
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nud_Cantidad.Location = new System.Drawing.Point(555, 314);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(53, 20);
            this.nud_Cantidad.TabIndex = 33;
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            this.nud_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Cantidad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(488, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cantidad:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_agregar.Location = new System.Drawing.Point(654, 314);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(72, 25);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar Cajero";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codigo.Location = new System.Drawing.Point(190, 314);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Size = new System.Drawing.Size(255, 20);
            this.codigo.TabIndex = 34;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(187, 343);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(36, 13);
            this.admin.TabIndex = 35;
            this.admin.Text = "Admin";
            this.admin.Visible = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(191, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Punto de reorden";
            // 
            // btn_caja
            // 
            this.btn_caja.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_caja.Location = new System.Drawing.Point(12, 193);
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Size = new System.Drawing.Size(139, 27);
            this.btn_caja.TabIndex = 0;
            this.btn_caja.Text = "Gestionar Cajas";
            this.btn_caja.UseVisualStyleBackColor = false;
            this.btn_caja.Click += new System.EventHandler(this.btn_Cajas_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cerrar.Location = new System.Drawing.Point(23, 343);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_rCajero
            // 
            this.btn_rCajero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rCajero.Location = new System.Drawing.Point(12, 268);
            this.btn_rCajero.Name = "btn_rCajero";
            this.btn_rCajero.Size = new System.Drawing.Size(139, 27);
            this.btn_rCajero.TabIndex = 37;
            this.btn_rCajero.Text = "Reporte de cajero";
            this.btn_rCajero.UseVisualStyleBackColor = false;
            this.btn_rCajero.Click += new System.EventHandler(this.btn_rCajero_Click);
            // 
            // btn_rVentas
            // 
            this.btn_rVentas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rVentas.Location = new System.Drawing.Point(12, 230);
            this.btn_rVentas.Name = "btn_rVentas";
            this.btn_rVentas.Size = new System.Drawing.Size(139, 27);
            this.btn_rVentas.TabIndex = 38;
            this.btn_rVentas.Text = "Reporte de ventas";
            this.btn_rVentas.UseVisualStyleBackColor = false;
            this.btn_rVentas.Click += new System.EventHandler(this.btn_rVentas_Click);
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(773, 383);
            this.Controls.Add(this.btn_rCajero);
            this.Controls.Add(this.btn_rVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dgv_rPuntoRe);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_GesDep);
            this.Controls.Add(this.btn_caja);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_verCajero);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_usurio);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.Load += new System.EventHandler(this.InicioAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rPuntoRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_usurio;
        private System.Windows.Forms.Button btn_verCajero;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_GesDep;
        private System.Windows.Forms.DataGridView Dgv_rPuntoRe;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_caja;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_rCajero;
        private System.Windows.Forms.Button btn_rVentas;
    }
}