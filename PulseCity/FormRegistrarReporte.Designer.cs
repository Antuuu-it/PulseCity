namespace PulseCity
{
    partial class FormRegistrarReporte
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(288, 119);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(288, 193);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(50, 20);
            this.lblZona.TabIndex = 1;
            this.lblZona.Text = "Zona:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(292, 259);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(46, 20);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(382, 119);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipo.TabIndex = 3;
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(382, 190);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(121, 26);
            this.txtZona.TabIndex = 4;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(382, 256);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 28);
            this.cmbNivel.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(346, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormRegistrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.lblTipo);
            this.Name = "FormRegistrarReporte";
            this.Text = "FormRegistrarReporte";
            this.Load += new System.EventHandler(this.FormRegistrarReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnGuardar;
    }
}