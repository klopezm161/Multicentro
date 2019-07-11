namespace MulticentroProyectoFinal
{
    partial class Facturaciones
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
            this.btnCrearFacturacion = new System.Windows.Forms.Button();
            this.btnBuscarFacturacion = new System.Windows.Forms.Button();
            this.btnMenuPrincipalEnFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACIÓN";
            // 
            // btnCrearFacturacion
            // 
            this.btnCrearFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFacturacion.Location = new System.Drawing.Point(16, 96);
            this.btnCrearFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearFacturacion.Name = "btnCrearFacturacion";
            this.btnCrearFacturacion.Size = new System.Drawing.Size(163, 37);
            this.btnCrearFacturacion.TabIndex = 1;
            this.btnCrearFacturacion.Text = "Crear";
            this.btnCrearFacturacion.UseVisualStyleBackColor = true;
            this.btnCrearFacturacion.Click += new System.EventHandler(this.BtnCrearFacturacion_Click);
            // 
            // btnBuscarFacturacion
            // 
            this.btnBuscarFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFacturacion.Location = new System.Drawing.Point(253, 96);
            this.btnBuscarFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFacturacion.Name = "btnBuscarFacturacion";
            this.btnBuscarFacturacion.Size = new System.Drawing.Size(156, 37);
            this.btnBuscarFacturacion.TabIndex = 2;
            this.btnBuscarFacturacion.Text = "Buscar";
            this.btnBuscarFacturacion.UseVisualStyleBackColor = true;
            this.btnBuscarFacturacion.Click += new System.EventHandler(this.BtnBuscarFacturacion_Click);
            // 
            // btnMenuPrincipalEnFacturacion
            // 
            this.btnMenuPrincipalEnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnFacturacion.Location = new System.Drawing.Point(253, 262);
            this.btnMenuPrincipalEnFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuPrincipalEnFacturacion.Name = "btnMenuPrincipalEnFacturacion";
            this.btnMenuPrincipalEnFacturacion.Size = new System.Drawing.Size(163, 39);
            this.btnMenuPrincipalEnFacturacion.TabIndex = 4;
            this.btnMenuPrincipalEnFacturacion.Text = "Menú Principal";
            this.btnMenuPrincipalEnFacturacion.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnFacturacion.Click += new System.EventHandler(this.BtnMenuPrincipalEnFacturacion_Click);
            // 
            // Facturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 316);
            this.Controls.Add(this.btnMenuPrincipalEnFacturacion);
            this.Controls.Add(this.btnBuscarFacturacion);
            this.Controls.Add(this.btnCrearFacturacion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturaciones";
            this.Text = "Facturaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturaciones_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearFacturacion;
        private System.Windows.Forms.Button btnBuscarFacturacion;
        private System.Windows.Forms.Button btnMenuPrincipalEnFacturacion;
    }
}