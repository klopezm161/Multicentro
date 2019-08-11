namespace MulticentroProyectoFinal
{
    partial class ServiciosBusqueda
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
            this.lblCodigoB = new System.Windows.Forms.Label();
            this.lblNombreB = new System.Windows.Forms.Label();
            this.btnBuscarBusquedaServicio = new System.Windows.Forms.Button();
            this.txtNombreBusquedaServicio = new System.Windows.Forms.TextBox();
            this.txtCodigoBusquedaServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuPrincipalEnBusquedaServicio = new System.Windows.Forms.Button();
            this.dGVBusquedaServicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusquedaServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoB
            // 
            this.lblCodigoB.AutoSize = true;
            this.lblCodigoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoB.Location = new System.Drawing.Point(14, 80);
            this.lblCodigoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoB.Name = "lblCodigoB";
            this.lblCodigoB.Size = new System.Drawing.Size(70, 20);
            this.lblCodigoB.TabIndex = 1;
            this.lblCodigoB.Text = "Código:";
            // 
            // lblNombreB
            // 
            this.lblNombreB.AutoSize = true;
            this.lblNombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreB.Location = new System.Drawing.Point(14, 120);
            this.lblNombreB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreB.Name = "lblNombreB";
            this.lblNombreB.Size = new System.Drawing.Size(76, 20);
            this.lblNombreB.TabIndex = 2;
            this.lblNombreB.Text = "Nombre:";
            // 
            // btnBuscarBusquedaServicio
            // 
            this.btnBuscarBusquedaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBusquedaServicio.Location = new System.Drawing.Point(358, 400);
            this.btnBuscarBusquedaServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarBusquedaServicio.Name = "btnBuscarBusquedaServicio";
            this.btnBuscarBusquedaServicio.Size = new System.Drawing.Size(145, 28);
            this.btnBuscarBusquedaServicio.TabIndex = 3;
            this.btnBuscarBusquedaServicio.Text = "Buscar";
            this.btnBuscarBusquedaServicio.UseVisualStyleBackColor = true;
            this.btnBuscarBusquedaServicio.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtNombreBusquedaServicio
            // 
            this.txtNombreBusquedaServicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreBusquedaServicio.Location = new System.Drawing.Point(131, 120);
            this.txtNombreBusquedaServicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBusquedaServicio.Name = "txtNombreBusquedaServicio";
            this.txtNombreBusquedaServicio.Size = new System.Drawing.Size(372, 20);
            this.txtNombreBusquedaServicio.TabIndex = 4;
            // 
            // txtCodigoBusquedaServicio
            // 
            this.txtCodigoBusquedaServicio.Location = new System.Drawing.Point(131, 80);
            this.txtCodigoBusquedaServicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoBusquedaServicio.Name = "txtCodigoBusquedaServicio";
            this.txtCodigoBusquedaServicio.Size = new System.Drawing.Size(372, 20);
            this.txtCodigoBusquedaServicio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "BÚSQUEDA SERVICIO";
            // 
            // btnMenuPrincipalEnBusquedaServicio
            // 
            this.btnMenuPrincipalEnBusquedaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnBusquedaServicio.Location = new System.Drawing.Point(14, 400);
            this.btnMenuPrincipalEnBusquedaServicio.Name = "btnMenuPrincipalEnBusquedaServicio";
            this.btnMenuPrincipalEnBusquedaServicio.Size = new System.Drawing.Size(145, 28);
            this.btnMenuPrincipalEnBusquedaServicio.TabIndex = 10;
            this.btnMenuPrincipalEnBusquedaServicio.Text = "Menú Principal";
            this.btnMenuPrincipalEnBusquedaServicio.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnBusquedaServicio.Click += new System.EventHandler(this.BtnMenuPrincipalEnBusquedaServicio_Click);
            // 
            // dGVBusquedaServicio
            // 
            this.dGVBusquedaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBusquedaServicio.Location = new System.Drawing.Point(18, 454);
            this.dGVBusquedaServicio.Name = "dGVBusquedaServicio";
            this.dGVBusquedaServicio.Size = new System.Drawing.Size(485, 250);
            this.dGVBusquedaServicio.TabIndex = 11;
            // 
            // ServiciosBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 736);
            this.Controls.Add(this.dGVBusquedaServicio);
            this.Controls.Add(this.btnMenuPrincipalEnBusquedaServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBusquedaServicio);
            this.Controls.Add(this.txtNombreBusquedaServicio);
            this.Controls.Add(this.btnBuscarBusquedaServicio);
            this.Controls.Add(this.lblNombreB);
            this.Controls.Add(this.lblCodigoB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiciosBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Servicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiciosBusqueda_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusquedaServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigoB;
        private System.Windows.Forms.Label lblNombreB;
        private System.Windows.Forms.Button btnBuscarBusquedaServicio;
        private System.Windows.Forms.TextBox txtNombreBusquedaServicio;
        private System.Windows.Forms.TextBox txtCodigoBusquedaServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuPrincipalEnBusquedaServicio;
        private System.Windows.Forms.DataGridView dGVBusquedaServicio;
    }
}