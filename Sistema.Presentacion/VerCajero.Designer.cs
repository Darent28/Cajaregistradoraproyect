namespace Sistema.Presentacion
{
    partial class VerCajero
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
            this.Dgv_rCajero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CURP = new System.Windows.Forms.TextBox();
            this.nNomina = new System.Windows.Forms.TextBox();
            this.NomCompleto = new System.Windows.Forms.TextBox();
            this.ClaveUsu = new System.Windows.Forms.TextBox();
            this.fNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.Adminnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_VerModCajero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_rCajero
            // 
            this.Dgv_rCajero.AllowUserToAddRows = false;
            this.Dgv_rCajero.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_rCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rCajero.Location = new System.Drawing.Point(293, 52);
            this.Dgv_rCajero.Name = "Dgv_rCajero";
            this.Dgv_rCajero.Size = new System.Drawing.Size(1102, 391);
            this.Dgv_rCajero.TabIndex = 18;
            this.Dgv_rCajero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rCajero_CellClick);
            this.Dgv_rCajero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rCajero_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ver Cajeros";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(1271, 508);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Modificar.Location = new System.Drawing.Point(28, 447);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(87, 23);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Location = new System.Drawing.Point(146, 447);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 23);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(28, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero de nómina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(27, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Clave de Usuario";
            // 
            // CURP
            // 
            this.CURP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CURP.Location = new System.Drawing.Point(27, 204);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(194, 20);
            this.CURP.TabIndex = 23;
            // 
            // nNomina
            // 
            this.nNomina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nNomina.Location = new System.Drawing.Point(27, 254);
            this.nNomina.Name = "nNomina";
            this.nNomina.ReadOnly = true;
            this.nNomina.Size = new System.Drawing.Size(194, 20);
            this.nNomina.TabIndex = 24;
            // 
            // NomCompleto
            // 
            this.NomCompleto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NomCompleto.Location = new System.Drawing.Point(27, 155);
            this.NomCompleto.Name = "NomCompleto";
            this.NomCompleto.Size = new System.Drawing.Size(194, 20);
            this.NomCompleto.TabIndex = 25;
            // 
            // ClaveUsu
            // 
            this.ClaveUsu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClaveUsu.Location = new System.Drawing.Point(27, 109);
            this.ClaveUsu.Name = "ClaveUsu";
            this.ClaveUsu.ReadOnly = true;
            this.ClaveUsu.Size = new System.Drawing.Size(194, 20);
            this.ClaveUsu.TabIndex = 26;
            // 
            // fNacimiento
            // 
            this.fNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.fNacimiento.Location = new System.Drawing.Point(27, 412);
            this.fNacimiento.Name = "fNacimiento";
            this.fNacimiento.Size = new System.Drawing.Size(233, 20);
            this.fNacimiento.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(29, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(28, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(28, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Contraseña";
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Correo.Location = new System.Drawing.Point(28, 359);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(194, 20);
            this.Correo.TabIndex = 31;
            // 
            // Contrasena
            // 
            this.Contrasena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Contrasena.Location = new System.Drawing.Point(28, 310);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(194, 20);
            this.Contrasena.TabIndex = 32;
            // 
            // Adminnom
            // 
            this.Adminnom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Adminnom.Location = new System.Drawing.Point(128, 517);
            this.Adminnom.Name = "Adminnom";
            this.Adminnom.ReadOnly = true;
            this.Adminnom.Size = new System.Drawing.Size(194, 20);
            this.Adminnom.TabIndex = 25;
            this.Adminnom.TextChanged += new System.EventHandler(this.Adminnom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quien lo Registra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_VerModCajero
            // 
            this.btn_VerModCajero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_VerModCajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_VerModCajero.Location = new System.Drawing.Point(1208, 12);
            this.btn_VerModCajero.Name = "btn_VerModCajero";
            this.btn_VerModCajero.Size = new System.Drawing.Size(150, 23);
            this.btn_VerModCajero.TabIndex = 20;
            this.btn_VerModCajero.Text = "Ver Modificaciones";
            this.btn_VerModCajero.UseVisualStyleBackColor = false;
            this.btn_VerModCajero.Click += new System.EventHandler(this.btn_VerModCajero_Click);
            // 
            // VerCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1370, 543);
            this.Controls.Add(this.fNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CURP);
            this.Controls.Add(this.nNomina);
            this.Controls.Add(this.Adminnom);
            this.Controls.Add(this.NomCompleto);
            this.Controls.Add(this.ClaveUsu);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_VerModCajero);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_rCajero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "VerCajero";
            this.Text = "VerCajero";
            this.Load += new System.EventHandler(this.VerCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_rCajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CURP;
        private System.Windows.Forms.TextBox nNomina;
        private System.Windows.Forms.TextBox NomCompleto;
        private System.Windows.Forms.TextBox ClaveUsu;
        private System.Windows.Forms.DateTimePicker fNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox Adminnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_VerModCajero;
    }
}