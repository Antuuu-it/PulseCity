namespace PulseCity
{
    partial class FormDashboard
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
            this.lblTrafico = new System.Windows.Forms.Label();
            this.lblAgua = new System.Windows.Forms.Label();
            this.lblContaminacion = new System.Windows.Forms.Label();
            this.lblBasura = new System.Windows.Forms.Label();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblRuido = new System.Windows.Forms.Label();
            this.btnRegistrarReporte = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pulse City";
            // 
            // lblTrafico
            // 
            this.lblTrafico.AutoSize = true;
            this.lblTrafico.Location = new System.Drawing.Point(190, 135);
            this.lblTrafico.Name = "lblTrafico";
            this.lblTrafico.Size = new System.Drawing.Size(61, 20);
            this.lblTrafico.TabIndex = 1;
            this.lblTrafico.Text = "Trafico:";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Location = new System.Drawing.Point(190, 264);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(49, 20);
            this.lblAgua.TabIndex = 2;
            this.lblAgua.Text = "agua:";
            // 
            // lblContaminacion
            // 
            this.lblContaminacion.AutoSize = true;
            this.lblContaminacion.Location = new System.Drawing.Point(190, 178);
            this.lblContaminacion.Name = "lblContaminacion";
            this.lblContaminacion.Size = new System.Drawing.Size(119, 20);
            this.lblContaminacion.TabIndex = 3;
            this.lblContaminacion.Text = "Contaminacion:";
            // 
            // lblBasura
            // 
            this.lblBasura.AutoSize = true;
            this.lblBasura.Location = new System.Drawing.Point(190, 223);
            this.lblBasura.Name = "lblBasura";
            this.lblBasura.Size = new System.Drawing.Size(64, 20);
            this.lblBasura.TabIndex = 4;
            this.lblBasura.Text = "Basura:";
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Location = new System.Drawing.Point(190, 306);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(86, 20);
            this.lblSeguridad.TabIndex = 5;
            this.lblSeguridad.Text = "Seguridad:";
            // 
            // lblRuido
            // 
            this.lblRuido.AutoSize = true;
            this.lblRuido.Location = new System.Drawing.Point(190, 349);
            this.lblRuido.Name = "lblRuido";
            this.lblRuido.Size = new System.Drawing.Size(55, 20);
            this.lblRuido.TabIndex = 6;
            this.lblRuido.Text = "Ruido:";
            // 
            // btnRegistrarReporte
            // 
            this.btnRegistrarReporte.Location = new System.Drawing.Point(500, 170);
            this.btnRegistrarReporte.Name = "btnRegistrarReporte";
            this.btnRegistrarReporte.Size = new System.Drawing.Size(149, 28);
            this.btnRegistrarReporte.TabIndex = 7;
            this.btnRegistrarReporte.Text = "Registrar Reporte";
            this.btnRegistrarReporte.UseVisualStyleBackColor = true;
            this.btnRegistrarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(500, 236);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(149, 26);
            this.btnVerReportes.TabIndex = 8;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.Location = new System.Drawing.Point(500, 298);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(149, 28);
            this.btnActualizarDatos.TabIndex = 9;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = true;
            this.btnActualizarDatos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(412, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.btnRegistrarReporte);
            this.Controls.Add(this.lblRuido);
            this.Controls.Add(this.lblSeguridad);
            this.Controls.Add(this.lblBasura);
            this.Controls.Add(this.lblContaminacion);
            this.Controls.Add(this.lblAgua);
            this.Controls.Add(this.lblTrafico);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrafico;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.Label lblContaminacion;
        private System.Windows.Forms.Label lblBasura;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblRuido;
        private System.Windows.Forms.Button btnRegistrarReporte;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}