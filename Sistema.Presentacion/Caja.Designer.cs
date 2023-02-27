
namespace Sistema.Presentacion
{
    partial class Caja
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
            this.btn_bajalogica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Registeredby = new System.Windows.Forms.TextBox();
            this.idDepa = new System.Windows.Forms.TextBox();
            this.Cajas = new System.Windows.Forms.TextBox();
            this.Dgv_rDepartamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bajalogica
            // 
            this.btn_bajalogica.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_bajalogica.Location = new System.Drawing.Point(397, 406);
            this.btn_bajalogica.Name = "btn_bajalogica";
            this.btn_bajalogica.Size = new System.Drawing.Size(73, 23);
            this.btn_bajalogica.TabIndex = 47;
            this.btn_bajalogica.Text = "Eliminar";
            this.btn_bajalogica.UseVisualStyleBackColor = false;
            this.btn_bajalogica.Click += new System.EventHandler(this.btn_bajalogica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Favor de limpiar la información antes de crear uno nuevo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_cancelar.Location = new System.Drawing.Point(721, 406);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Modificar.Location = new System.Drawing.Point(295, 406);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 44;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_limpiar.Location = new System.Drawing.Point(186, 119);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 42;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_aceptar.Location = new System.Drawing.Point(280, 80);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 43;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Manejo de Cajas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(554, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Quien lo registra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(68, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(52, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Caja:";
            // 
            // Registeredby
            // 
            this.Registeredby.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Registeredby.Location = new System.Drawing.Point(664, 146);
            this.Registeredby.Name = "Registeredby";
            this.Registeredby.ReadOnly = true;
            this.Registeredby.Size = new System.Drawing.Size(124, 20);
            this.Registeredby.TabIndex = 35;
            // 
            // idDepa
            // 
            this.idDepa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idDepa.Location = new System.Drawing.Point(94, 119);
            this.idDepa.Name = "idDepa";
            this.idDepa.ReadOnly = true;
            this.idDepa.Size = new System.Drawing.Size(60, 20);
            this.idDepa.TabIndex = 36;
            // 
            // Cajas
            // 
            this.Cajas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cajas.Location = new System.Drawing.Point(94, 80);
            this.Cajas.Name = "Cajas";
            this.Cajas.Size = new System.Drawing.Size(167, 20);
            this.Cajas.TabIndex = 37;
            // 
            // Dgv_rDepartamento
            // 
            this.Dgv_rDepartamento.AllowUserToAddRows = false;
            this.Dgv_rDepartamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_rDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rDepartamento.Location = new System.Drawing.Point(5, 172);
            this.Dgv_rDepartamento.Name = "Dgv_rDepartamento";
            this.Dgv_rDepartamento.Size = new System.Drawing.Size(794, 217);
            this.Dgv_rDepartamento.TabIndex = 34;
            this.Dgv_rDepartamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rDepartamento_CellClick);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bajalogica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Registeredby);
            this.Controls.Add(this.idDepa);
            this.Controls.Add(this.Cajas);
            this.Controls.Add(this.Dgv_rDepartamento);
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bajalogica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Registeredby;
        private System.Windows.Forms.TextBox idDepa;
        private System.Windows.Forms.TextBox Cajas;
        public System.Windows.Forms.DataGridView Dgv_rDepartamento;
    }
}