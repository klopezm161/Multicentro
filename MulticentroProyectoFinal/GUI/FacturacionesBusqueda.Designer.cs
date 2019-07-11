namespace MulticentroProyectoFinal
{
    partial class FacturacionesBusquesa
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
            this.txtNumFacturaFacturacionesBusqueda = new System.Windows.Forms.TextBox();
            this.btnAceptarFacturacionesBusqueda = new System.Windows.Forms.Button();
            this.btnMenuPrincipalFacturacionesBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Factura:";
            // 
            // txtNumFacturaFacturacionesBusqueda
            // 
            this.txtNumFacturaFacturacionesBusqueda.Location = new System.Drawing.Point(179, 121);
            this.txtNumFacturaFacturacionesBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumFacturaFacturacionesBusqueda.Name = "txtNumFacturaFacturacionesBusqueda";
            this.txtNumFacturaFacturacionesBusqueda.Size = new System.Drawing.Size(180, 30);
            this.txtNumFacturaFacturacionesBusqueda.TabIndex = 2;
            // 
            // btnAceptarFacturacionesBusqueda
            // 
            this.btnAceptarFacturacionesBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFacturacionesBusqueda.Location = new System.Drawing.Point(234, 192);
            this.btnAceptarFacturacionesBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptarFacturacionesBusqueda.Name = "btnAceptarFacturacionesBusqueda";
            this.btnAceptarFacturacionesBusqueda.Size = new System.Drawing.Size(125, 35);
            this.btnAceptarFacturacionesBusqueda.TabIndex = 3;
            this.btnAceptarFacturacionesBusqueda.Text = "Aceptar";
            this.btnAceptarFacturacionesBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipalFacturacionesBusqueda
            // 
            this.btnMenuPrincipalFacturacionesBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalFacturacionesBusqueda.Location = new System.Drawing.Point(234, 300);
            this.btnMenuPrincipalFacturacionesBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuPrincipalFacturacionesBusqueda.Name = "btnMenuPrincipalFacturacionesBusqueda";
            this.btnMenuPrincipalFacturacionesBusqueda.Size = new System.Drawing.Size(125, 35);
            this.btnMenuPrincipalFacturacionesBusqueda.TabIndex = 4;
            this.btnMenuPrincipalFacturacionesBusqueda.Text = "Menú Principal";
            this.btnMenuPrincipalFacturacionesBusqueda.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalFacturacionesBusqueda.Click += new System.EventHandler(this.BtnMenuPrincipalFacturacionesBusqueda_Click);
            // 
            // FacturacionesBusquesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 391);
            this.Controls.Add(this.btnMenuPrincipalFacturacionesBusqueda);
            this.Controls.Add(this.btnAceptarFacturacionesBusqueda);
            this.Controls.Add(this.txtNumFacturaFacturacionesBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FacturacionesBusquesa";
            this.Text = "FacturacionesBusquesa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FacturacionesBusquesa_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFacturaFacturacionesBusqueda;
        private System.Windows.Forms.Button btnAceptarFacturacionesBusqueda;
        private System.Windows.Forms.Button btnMenuPrincipalFacturacionesBusqueda;
    }
}