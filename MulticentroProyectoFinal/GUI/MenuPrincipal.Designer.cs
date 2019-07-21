namespace MulticentroProyectoFinal
{
    partial class MenuPrincipal
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
            this.btnRegresarMenuPrincipal = new System.Windows.Forms.Button();
            this.cBoxProductos = new System.Windows.Forms.ComboBox();
            this.cBoxServicios = new System.Windows.Forms.ComboBox();
            this.cBoxFacturacion = new System.Windows.Forms.ComboBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MULTICENTRO ARIAS \r\n    MENÚ PRINCIPAL";
            // 
            // btnRegresarMenuPrincipal
            // 
            this.btnRegresarMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal.Location = new System.Drawing.Point(363, 400);
            this.btnRegresarMenuPrincipal.Name = "btnRegresarMenuPrincipal";
            this.btnRegresarMenuPrincipal.Size = new System.Drawing.Size(145, 28);
            this.btnRegresarMenuPrincipal.TabIndex = 4;
            this.btnRegresarMenuPrincipal.Text = "Regresar";
            this.btnRegresarMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal.Click += new System.EventHandler(this.BtnRegresarMenuPrincipal_Click);
            // 
            // cBoxProductos
            // 
            this.cBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxProductos.FormattingEnabled = true;
            this.cBoxProductos.Items.AddRange(new object[] {
            "Agregar",
            "Buscar",
            "Actualizar"});
            this.cBoxProductos.Location = new System.Drawing.Point(144, 50);
            this.cBoxProductos.Name = "cBoxProductos";
            this.cBoxProductos.Size = new System.Drawing.Size(190, 28);
            this.cBoxProductos.TabIndex = 14;
            // 
            // cBoxServicios
            // 
            this.cBoxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxServicios.FormattingEnabled = true;
            this.cBoxServicios.Items.AddRange(new object[] {
            "Agregar",
            "Buscar",
            "Actualizar"});
            this.cBoxServicios.Location = new System.Drawing.Point(144, 185);
            this.cBoxServicios.Name = "cBoxServicios";
            this.cBoxServicios.Size = new System.Drawing.Size(190, 28);
            this.cBoxServicios.TabIndex = 15;
            // 
            // cBoxFacturacion
            // 
            this.cBoxFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFacturacion.FormattingEnabled = true;
            this.cBoxFacturacion.Items.AddRange(new object[] {
            "Agregar",
            "Buscar"});
            this.cBoxFacturacion.Location = new System.Drawing.Point(144, 116);
            this.cBoxFacturacion.Name = "cBoxFacturacion";
            this.cBoxFacturacion.Size = new System.Drawing.Size(190, 28);
            this.cBoxFacturacion.TabIndex = 16;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(349, 50);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(145, 28);
            this.btnProductos.TabIndex = 17;
            this.btnProductos.Text = "Seleccionar";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(349, 116);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(145, 28);
            this.btnFacturacion.TabIndex = 18;
            this.btnFacturacion.Text = "Seleccionar";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Location = new System.Drawing.Point(349, 185);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(145, 28);
            this.btnServicios.TabIndex = 19;
            this.btnServicios.Text = "Seleccionar";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.BtnServicios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Facturación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Servicios";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cBoxServicios);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cBoxProductos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cBoxFacturacion);
            this.panel1.Controls.Add(this.btnServicios);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnFacturacion);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 276);
            this.panel1.TabIndex = 23;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.btnRegresarMenuPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal;
        private System.Windows.Forms.ComboBox cBoxProductos;
        private System.Windows.Forms.ComboBox cBoxServicios;
        private System.Windows.Forms.ComboBox cBoxFacturacion;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}