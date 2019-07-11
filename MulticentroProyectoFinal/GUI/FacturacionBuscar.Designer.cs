namespace MulticentroProyectoFinal.GUI
{
    partial class FacturacionBuscar
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
            this.txtNumFacturaFacturacionBuscar = new System.Windows.Forms.TextBox();
            this.btnAceptarFacturacionBuscar = new System.Windows.Forms.Button();
            this.btnMenuPrincipalEnFacturacionBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Factura:";
            // 
            // txtNumFacturaFacturacionBuscar
            // 
            this.txtNumFacturaFacturacionBuscar.Location = new System.Drawing.Point(248, 128);
            this.txtNumFacturaFacturacionBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumFacturaFacturacionBuscar.Name = "txtNumFacturaFacturacionBuscar";
            this.txtNumFacturaFacturacionBuscar.Size = new System.Drawing.Size(200, 22);
            this.txtNumFacturaFacturacionBuscar.TabIndex = 2;
            // 
            // btnAceptarFacturacionBuscar
            // 
            this.btnAceptarFacturacionBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFacturacionBuscar.Location = new System.Drawing.Point(281, 176);
            this.btnAceptarFacturacionBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarFacturacionBuscar.Name = "btnAceptarFacturacionBuscar";
            this.btnAceptarFacturacionBuscar.Size = new System.Drawing.Size(168, 39);
            this.btnAceptarFacturacionBuscar.TabIndex = 3;
            this.btnAceptarFacturacionBuscar.Text = "Aceptar";
            this.btnAceptarFacturacionBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipalEnFacturacionBuscar
            // 
            this.btnMenuPrincipalEnFacturacionBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnFacturacionBuscar.Location = new System.Drawing.Point(281, 354);
            this.btnMenuPrincipalEnFacturacionBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuPrincipalEnFacturacionBuscar.Name = "btnMenuPrincipalEnFacturacionBuscar";
            this.btnMenuPrincipalEnFacturacionBuscar.Size = new System.Drawing.Size(168, 39);
            this.btnMenuPrincipalEnFacturacionBuscar.TabIndex = 5;
            this.btnMenuPrincipalEnFacturacionBuscar.Text = "Menú Principal";
            this.btnMenuPrincipalEnFacturacionBuscar.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnFacturacionBuscar.Click += new System.EventHandler(this.BtnMenuPrincipalEnFacturacionBuscar_Click);
            // 
            // FacturacionBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 409);
            this.Controls.Add(this.btnMenuPrincipalEnFacturacionBuscar);
            this.Controls.Add(this.btnAceptarFacturacionBuscar);
            this.Controls.Add(this.txtNumFacturaFacturacionBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacturacionBuscar";
            this.Text = "FacturacionBuscar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FacturacionBuscar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFacturaFacturacionBuscar;
        private System.Windows.Forms.Button btnAceptarFacturacionBuscar;
        private System.Windows.Forms.Button btnMenuPrincipalEnFacturacionBuscar;
    }
}