namespace Sistema.Presentacion
{
    partial class ReporteCajero
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_rCajero = new System.Windows.Forms.DataGridView();
            this.cb_Cajero = new System.Windows.Forms.ComboBox();
            this.cb_Departamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_fFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_buscartodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_buscar.Location = new System.Drawing.Point(353, 131);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Dgv_rCajero
            // 
            this.Dgv_rCajero.AllowUserToAddRows = false;
            this.Dgv_rCajero.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_rCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rCajero.Location = new System.Drawing.Point(12, 199);
            this.Dgv_rCajero.Name = "Dgv_rCajero";
            this.Dgv_rCajero.Size = new System.Drawing.Size(776, 208);
            this.Dgv_rCajero.TabIndex = 17;
            // 
            // cb_Cajero
            // 
            this.cb_Cajero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_Cajero.FormattingEnabled = true;
            this.cb_Cajero.Location = new System.Drawing.Point(40, 133);
            this.cb_Cajero.Name = "cb_Cajero";
            this.cb_Cajero.Size = new System.Drawing.Size(151, 21);
            this.cb_Cajero.TabIndex = 15;
            this.cb_Cajero.SelectedIndexChanged += new System.EventHandler(this.cb_Cajero_SelectedIndexChanged);
            this.cb_Cajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Cajero_KeyPress);
            // 
            // cb_Departamento
            // 
            this.cb_Departamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_Departamento.FormattingEnabled = true;
            this.cb_Departamento.Location = new System.Drawing.Point(40, 88);
            this.cb_Departamento.Name = "cb_Departamento";
            this.cb_Departamento.Size = new System.Drawing.Size(151, 21);
            this.cb_Departamento.TabIndex = 16;
            this.cb_Departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Departamento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(37, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cajero";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.groupBox1.Controls.Add(this.dtp_fFin);
            this.groupBox1.Controls.Add(this.dtp_fInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(569, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de fechas";
            // 
            // dtp_fFin
            // 
            this.dtp_fFin.Location = new System.Drawing.Point(6, 79);
            this.dtp_fFin.Name = "dtp_fFin";
            this.dtp_fFin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fFin.TabIndex = 6;
            // 
            // dtp_fInicio
            // 
            this.dtp_fInicio.Location = new System.Drawing.Point(6, 40);
            this.dtp_fInicio.Name = "dtp_fInicio";
            this.dtp_fInicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_fInicio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reporte de cajero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_aceptar.Location = new System.Drawing.Point(353, 427);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_buscartodas
            // 
            this.btn_buscartodas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_buscartodas.Location = new System.Drawing.Point(345, 158);
            this.btn_buscartodas.Name = "btn_buscartodas";
            this.btn_buscartodas.Size = new System.Drawing.Size(93, 23);
            this.btn_buscartodas.TabIndex = 18;
            this.btn_buscartodas.Text = "Buscar Todas";
            this.btn_buscartodas.UseVisualStyleBackColor = false;
            this.btn_buscartodas.Click += new System.EventHandler(this.btn_buscartodas_Click);
            // 
            // ReporteCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscartodas);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Dgv_rCajero);
            this.Controls.Add(this.cb_Cajero);
            this.Controls.Add(this.cb_Departamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteCajero";
            this.Text = "ReporteCajero";
            this.Load += new System.EventHandler(this.ReporteCajero_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReporteCajero_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_rCajero;
        private System.Windows.Forms.ComboBox cb_Cajero;
        private System.Windows.Forms.ComboBox cb_Departamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fFin;
        private System.Windows.Forms.DateTimePicker dtp_fInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_buscartodas;
    }
}