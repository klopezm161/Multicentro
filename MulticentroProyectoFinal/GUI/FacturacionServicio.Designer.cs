namespace MulticentroProyectoFinal.GUI
{
    partial class FacturacionServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionServicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvFacturaNueva = new System.Windows.Forms.DataGridView();
            this.btnAceptarFacturarCrear = new System.Windows.Forms.Button();
            this.lblPrecioFacturaServicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicioFacturaCrear = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Factura nueva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // dgvFacturaNueva
            // 
            this.dgvFacturaNueva.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturaNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaNueva.Location = new System.Drawing.Point(18, 311);
            this.dgvFacturaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFacturaNueva.Name = "dgvFacturaNueva";
            this.dgvFacturaNueva.Size = new System.Drawing.Size(485, 254);
            this.dgvFacturaNueva.TabIndex = 50;
            // 
            // btnAceptarFacturarCrear
            // 
            this.btnAceptarFacturarCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFacturarCrear.Location = new System.Drawing.Point(358, 268);
            this.btnAceptarFacturarCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarFacturarCrear.Name = "btnAceptarFacturarCrear";
            this.btnAceptarFacturarCrear.Size = new System.Drawing.Size(145, 28);
            this.btnAceptarFacturarCrear.TabIndex = 46;
            this.btnAceptarFacturarCrear.Text = "Agregar";
            this.btnAceptarFacturarCrear.UseVisualStyleBackColor = true;
            this.btnAceptarFacturarCrear.Click += new System.EventHandler(this.btnAceptarFacturarCrear_Click);
            // 
            // lblPrecioFacturaServicio
            // 
            this.lblPrecioFacturaServicio.AutoSize = true;
            this.lblPrecioFacturaServicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFacturaServicio.Location = new System.Drawing.Point(128, 217);
            this.lblPrecioFacturaServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioFacturaServicio.Name = "lblPrecioFacturaServicio";
            this.lblPrecioFacturaServicio.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioFacturaServicio.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar por código:";
            // 
            // txtServicioFacturaCrear
            // 
            this.txtServicioFacturaCrear.Location = new System.Drawing.Point(212, 193);
            this.txtServicioFacturaCrear.Margin = new System.Windows.Forms.Padding(2);
            this.txtServicioFacturaCrear.Name = "txtServicioFacturaCrear";
            this.txtServicioFacturaCrear.Size = new System.Drawing.Size(291, 20);
            this.txtServicioFacturaCrear.TabIndex = 54;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(212, 162);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(291, 20);
            this.txtCodigo.TabIndex = 55;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(18, 268);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 28);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FacturacionServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 576);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtServicioFacturaCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvFacturaNueva);
            this.Controls.Add(this.btnAceptarFacturarCrear);
            this.Controls.Add(this.lblPrecioFacturaServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacturacionServicio";
            this.Text = "FacturacionProductoServicio";
            this.Load += new System.EventHandler(this.FacturacionProductoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvFacturaNueva;
        private System.Windows.Forms.Button btnAceptarFacturarCrear;
        private System.Windows.Forms.Label lblPrecioFacturaServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServicioFacturaCrear;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
    }
}