namespace MulticentroProyectoFinal
{
    partial class Productos
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
            this.btnIngresarMenuProductos = new System.Windows.Forms.Button();
            this.btnBuscarMenuProductos = new System.Windows.Forms.Button();
            this.btnActualizarMenProductos = new System.Windows.Forms.Button();
            this.btnMenuPrincipalEnMenuProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // btnIngresarMenuProductos
            // 
            this.btnIngresarMenuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarMenuProductos.Location = new System.Drawing.Point(16, 126);
            this.btnIngresarMenuProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresarMenuProductos.Name = "btnIngresarMenuProductos";
            this.btnIngresarMenuProductos.Size = new System.Drawing.Size(144, 43);
            this.btnIngresarMenuProductos.TabIndex = 1;
            this.btnIngresarMenuProductos.Text = "Ingresar";
            this.btnIngresarMenuProductos.UseVisualStyleBackColor = true;
            this.btnIngresarMenuProductos.Click += new System.EventHandler(this.BtnIngresarMenuProductos_Click);
            // 
            // btnBuscarMenuProductos
            // 
            this.btnBuscarMenuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMenuProductos.Location = new System.Drawing.Point(168, 126);
            this.btnBuscarMenuProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarMenuProductos.Name = "btnBuscarMenuProductos";
            this.btnBuscarMenuProductos.Size = new System.Drawing.Size(144, 43);
            this.btnBuscarMenuProductos.TabIndex = 2;
            this.btnBuscarMenuProductos.Text = "Buscar";
            this.btnBuscarMenuProductos.UseVisualStyleBackColor = true;
            this.btnBuscarMenuProductos.Click += new System.EventHandler(this.BtnBuscarMenuProductos_Click);
            // 
            // btnActualizarMenProductos
            // 
            this.btnActualizarMenProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMenProductos.Location = new System.Drawing.Point(320, 126);
            this.btnActualizarMenProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarMenProductos.Name = "btnActualizarMenProductos";
            this.btnActualizarMenProductos.Size = new System.Drawing.Size(144, 43);
            this.btnActualizarMenProductos.TabIndex = 3;
            this.btnActualizarMenProductos.Text = "Actualizar";
            this.btnActualizarMenProductos.UseVisualStyleBackColor = true;
            this.btnActualizarMenProductos.Click += new System.EventHandler(this.BtnActualizarMenProductos_Click);
            // 
            // btnMenuPrincipalEnMenuProductos
            // 
            this.btnMenuPrincipalEnMenuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalEnMenuProductos.Location = new System.Drawing.Point(168, 275);
            this.btnMenuPrincipalEnMenuProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuPrincipalEnMenuProductos.Name = "btnMenuPrincipalEnMenuProductos";
            this.btnMenuPrincipalEnMenuProductos.Size = new System.Drawing.Size(144, 46);
            this.btnMenuPrincipalEnMenuProductos.TabIndex = 5;
            this.btnMenuPrincipalEnMenuProductos.Text = "Menú Principal";
            this.btnMenuPrincipalEnMenuProductos.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalEnMenuProductos.Click += new System.EventHandler(this.BtnMenuPrincipalEnMenuProductos_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 363);
            this.Controls.Add(this.btnMenuPrincipalEnMenuProductos);
            this.Controls.Add(this.btnActualizarMenProductos);
            this.Controls.Add(this.btnBuscarMenuProductos);
            this.Controls.Add(this.btnIngresarMenuProductos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Productos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarMenuProductos;
        private System.Windows.Forms.Button btnBuscarMenuProductos;
        private System.Windows.Forms.Button btnActualizarMenProductos;
        private System.Windows.Forms.Button btnMenuPrincipalEnMenuProductos;
    }
}