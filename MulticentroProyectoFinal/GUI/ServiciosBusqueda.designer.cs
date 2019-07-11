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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCodigoB = new System.Windows.Forms.Label();
            this.lblNombreB = new System.Windows.Forms.Label();
            this.btnBuscarBusquedaServicio = new System.Windows.Forms.Button();
            this.txtNombreBusquedaServicio = new System.Windows.Forms.TextBox();
            this.txtCodigoBusquedaServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxCategoriaBusquedaServicio = new System.Windows.Forms.ComboBox();
            this.btnMenuPrincipalEnBusquedaServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(39, 90);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 25);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblCodigoB
            // 
            this.lblCodigoB.AutoSize = true;
            this.lblCodigoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoB.Location = new System.Drawing.Point(39, 153);
            this.lblCodigoB.Name = "lblCodigoB";
            this.lblCodigoB.Size = new System.Drawing.Size(88, 25);
            this.lblCodigoB.TabIndex = 1;
            this.lblCodigoB.Text = "Código:";
            // 
            // lblNombreB
            // 
            this.lblNombreB.AutoSize = true;
            this.lblNombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreB.Location = new System.Drawing.Point(39, 217);
            this.lblNombreB.Name = "lblNombreB";
            this.lblNombreB.Size = new System.Drawing.Size(94, 25);
            this.lblNombreB.TabIndex = 2;
            this.lblNombreB.Text = "Nombre:";
            // 
            // btnBuscarBusquedaServicio
            // 
            this.btnBuscarBusquedaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBusquedaServicio.Location = new System.Drawing.Point(313, 260);
            this.btnBuscarBusquedaServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarBusquedaServicio.Name = "btnBuscarBusquedaServicio";
            this.btnBuscarBusquedaServicio.Size = new System.Drawing.Size(165, 38);
            this.btnBuscarBusquedaServicio.TabIndex = 3;
            this.btnBuscarBusquedaServicio.Text = "Buscar";
            this.btnBuscarBusquedaServicio.UseVisualStyleBackColor = true;
            this.btnBuscarBusquedaServicio.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtNombreBusquedaServicio
            // 
            this.txtNombreBusquedaServicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreBusquedaServicio.Location = new System.Drawing.Point(253, 217);
            this.txtNombreBusquedaServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreBusquedaServicio.Name = "txtNombreBusquedaServicio";
            this.txtNombreBusquedaServicio.Size = new System.Drawing.Size(224, 22);
            this.txtNombreBusquedaServicio.TabIndex = 4;
            // 
            // txtCodigoBusquedaServicio
            // 
            this.txtCodigoBusquedaServicio.Location = new System.Drawing.Point(253, 153);
            this.txtCodigoBusquedaServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBusquedaServicio.Name = "txtCodigoBusquedaServicio";
            this.txtCodigoBusquedaServicio.Size = new System.Drawing.Size(224, 22);
            this.txtCodigoBusquedaServicio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "BÚSQUEDA SERVICIO";
            // 
            // CBoxCategoriaBusquedaServicio
            // 
            this.CBoxCategoriaBusquedaServicio.FormattingEnabled = true;
            this.CBoxCategoriaBusquedaServicio.Location = new System.Drawing.Point(253, 89);
            this.CBoxCategoriaBusquedaServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBoxCategoriaBusquedaServicio.Name = "CBoxCategoriaBusquedaServicio";
            this.CBoxCategoriaBusquedaServicio.Size = new System.Drawing.Size(224, 24);
            this.CBoxCategoriaBusquedaServicio.TabIndex = 8;
            // 
            // btnMenuPrincipalEnBusquedaServicio
            // 
            this.btnMenuPrincipalEnBusquedaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnBusquedaServicio.Location = new System.Drawing.Point(313, 322);
            this.btnMenuPrincipalEnBusquedaServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuPrincipalEnBusquedaServicio.Name = "btnMenuPrincipalEnBusquedaServicio";
            this.btnMenuPrincipalEnBusquedaServicio.Size = new System.Drawing.Size(165, 38);
            this.btnMenuPrincipalEnBusquedaServicio.TabIndex = 10;
            this.btnMenuPrincipalEnBusquedaServicio.Text = "Menú Principal";
            this.btnMenuPrincipalEnBusquedaServicio.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnBusquedaServicio.Click += new System.EventHandler(this.BtnMenuPrincipalEnBusquedaServicio_Click);
            // 
            // ServiciosBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 375);
            this.Controls.Add(this.btnMenuPrincipalEnBusquedaServicio);
            this.Controls.Add(this.CBoxCategoriaBusquedaServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBusquedaServicio);
            this.Controls.Add(this.txtNombreBusquedaServicio);
            this.Controls.Add(this.btnBuscarBusquedaServicio);
            this.Controls.Add(this.lblNombreB);
            this.Controls.Add(this.lblCodigoB);
            this.Controls.Add(this.lblCategoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiciosBusqueda";
            this.Text = "Busqueda Servicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiciosBusqueda_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCodigoB;
        private System.Windows.Forms.Label lblNombreB;
        private System.Windows.Forms.Button btnBuscarBusquedaServicio;
        private System.Windows.Forms.TextBox txtNombreBusquedaServicio;
        private System.Windows.Forms.TextBox txtCodigoBusquedaServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxCategoriaBusquedaServicio;
        private System.Windows.Forms.Button btnMenuPrincipalEnBusquedaServicio;
    }
}