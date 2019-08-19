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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionBuscar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFacturaFacturacionBuscar = new System.Windows.Forms.TextBox();
            this.btnAceptarFacturacionBuscar = new System.Windows.Forms.Button();
            this.btnMenuPrincipalEnFacturacionBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Factura:";
            // 
            // txtNumFacturaFacturacionBuscar
            // 
            this.txtNumFacturaFacturacionBuscar.Location = new System.Drawing.Point(248, 166);
            this.txtNumFacturaFacturacionBuscar.Name = "txtNumFacturaFacturacionBuscar";
            this.txtNumFacturaFacturacionBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtNumFacturaFacturacionBuscar.TabIndex = 2;
            // 
            // btnAceptarFacturacionBuscar
            // 
            this.btnAceptarFacturacionBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFacturacionBuscar.Location = new System.Drawing.Point(248, 224);
            this.btnAceptarFacturacionBuscar.Name = "btnAceptarFacturacionBuscar";
            this.btnAceptarFacturacionBuscar.Size = new System.Drawing.Size(145, 28);
            this.btnAceptarFacturacionBuscar.TabIndex = 3;
            this.btnAceptarFacturacionBuscar.Text = "Aceptar";
            this.btnAceptarFacturacionBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipalEnFacturacionBuscar
            // 
            this.btnMenuPrincipalEnFacturacionBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnFacturacionBuscar.Location = new System.Drawing.Point(12, 88);
            this.btnMenuPrincipalEnFacturacionBuscar.Name = "btnMenuPrincipalEnFacturacionBuscar";
            this.btnMenuPrincipalEnFacturacionBuscar.Size = new System.Drawing.Size(145, 28);
            this.btnMenuPrincipalEnFacturacionBuscar.TabIndex = 5;
            this.btnMenuPrincipalEnFacturacionBuscar.Text = "Menú Principal";
            this.btnMenuPrincipalEnFacturacionBuscar.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnFacturacionBuscar.Click += new System.EventHandler(this.BtnMenuPrincipalEnFacturacionBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // FacturacionBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 576);
            this.Controls.Add(this.btnMenuPrincipalEnFacturacionBuscar);
            this.Controls.Add(this.btnAceptarFacturacionBuscar);
            this.Controls.Add(this.txtNumFacturaFacturacionBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FacturacionBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturacionBuscar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FacturacionBuscar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFacturaFacturacionBuscar;
        private System.Windows.Forms.Button btnAceptarFacturacionBuscar;
        private System.Windows.Forms.Button btnMenuPrincipalEnFacturacionBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}