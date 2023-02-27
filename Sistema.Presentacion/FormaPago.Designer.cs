namespace Sistema.Presentacion
{
    partial class FormaPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this._total = new System.Windows.Forms.TextBox();
            this._restante = new System.Windows.Forms.TextBox();
            this.cbox_mPago = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.deshacer = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.tbmetodo = new System.Windows.Forms.TextBox();
            this.cantidadP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metodo de Pago:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad a Pagar:";
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Location = new System.Drawing.Point(42, 198);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersVisible = false;
            this.dgPagos.Size = new System.Drawing.Size(326, 173);
            this.dgPagos.TabIndex = 1;
            this.dgPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagos_CellClick);
            // 
            // _total
            // 
            this._total.Location = new System.Drawing.Point(25, 44);
            this._total.Name = "_total";
            this._total.ReadOnly = true;
            this._total.Size = new System.Drawing.Size(150, 20);
            this._total.TabIndex = 2;
            this._total.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _restante
            // 
            this._restante.Location = new System.Drawing.Point(240, 44);
            this._restante.Name = "_restante";
            this._restante.ReadOnly = true;
            this._restante.Size = new System.Drawing.Size(150, 20);
            this._restante.TabIndex = 2;
            // 
            // cbox_mPago
            // 
            this.cbox_mPago.FormattingEnabled = true;
            this.cbox_mPago.Location = new System.Drawing.Point(25, 117);
            this.cbox_mPago.Name = "cbox_mPago";
            this.cbox_mPago.Size = new System.Drawing.Size(150, 21);
            this.cbox_mPago.TabIndex = 3;
            this.cbox_mPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_mPago_KeyPress);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(86, 169);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 4;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // deshacer
            // 
            this.deshacer.Location = new System.Drawing.Point(100, 8);
            this.deshacer.Name = "deshacer";
            this.deshacer.Size = new System.Drawing.Size(75, 23);
            this.deshacer.TabIndex = 4;
            this.deshacer.Text = "Deshacer";
            this.deshacer.UseVisualStyleBackColor = true;
            this.deshacer.Visible = false;
            this.deshacer.Click += new System.EventHandler(this.deshacer_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(167, 169);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 4;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(248, 169);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // tbmetodo
            // 
            this.tbmetodo.Location = new System.Drawing.Point(25, 70);
            this.tbmetodo.Name = "tbmetodo";
            this.tbmetodo.Size = new System.Drawing.Size(150, 20);
            this.tbmetodo.TabIndex = 2;
            this.tbmetodo.Visible = false;
            this.tbmetodo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbmetodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadP_KeyPress);
            // 
            // cantidadP
            // 
            this.cantidadP.DecimalPlaces = 2;
            this.cantidadP.Location = new System.Drawing.Point(240, 117);
            this.cantidadP.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.cantidadP.Name = "cantidadP";
            this.cantidadP.Size = new System.Drawing.Size(89, 20);
            this.cantidadP.TabIndex = 5;
            this.cantidadP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadP_KeyPress);
            // 
            // FormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 383);
            this.Controls.Add(this.cantidadP);
            this.Controls.Add(this.deshacer);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.cbox_mPago);
            this.Controls.Add(this._restante);
            this.Controls.Add(this.tbmetodo);
            this.Controls.Add(this._total);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormaPago";
            this.Text = "FormaPago";
            this.Load += new System.EventHandler(this.FormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.TextBox _total;
        private System.Windows.Forms.TextBox _restante;
        private System.Windows.Forms.ComboBox cbox_mPago;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button deshacer;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox tbmetodo;
        private System.Windows.Forms.NumericUpDown cantidadP;
    }
}