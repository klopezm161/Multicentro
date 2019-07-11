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
            this.btnServiciosMenuPrincipal = new System.Windows.Forms.Button();
            this.btnFacturacionMenuPrincipal = new System.Windows.Forms.Button();
            this.btnProductosMenuPrincipal = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "MULTICENTRO ARIAS \r\n    MENÚ PRINCIPAL";
            // 
            // btnServiciosMenuPrincipal
            // 
            this.btnServiciosMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiciosMenuPrincipal.Location = new System.Drawing.Point(157, 130);
            this.btnServiciosMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiciosMenuPrincipal.Name = "btnServiciosMenuPrincipal";
            this.btnServiciosMenuPrincipal.Size = new System.Drawing.Size(147, 47);
            this.btnServiciosMenuPrincipal.TabIndex = 1;
            this.btnServiciosMenuPrincipal.Text = "Servicios";
            this.btnServiciosMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnServiciosMenuPrincipal.Click += new System.EventHandler(this.BtnServiciosMenuPrincipal_Click);
            // 
            // btnFacturacionMenuPrincipal
            // 
            this.btnFacturacionMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionMenuPrincipal.Location = new System.Drawing.Point(312, 130);
            this.btnFacturacionMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturacionMenuPrincipal.Name = "btnFacturacionMenuPrincipal";
            this.btnFacturacionMenuPrincipal.Size = new System.Drawing.Size(160, 47);
            this.btnFacturacionMenuPrincipal.TabIndex = 2;
            this.btnFacturacionMenuPrincipal.Text = "Facturación";
            this.btnFacturacionMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnFacturacionMenuPrincipal.Click += new System.EventHandler(this.BtnFacturacionMenuPrincipal_Click);
            // 
            // btnProductosMenuPrincipal
            // 
            this.btnProductosMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosMenuPrincipal.Location = new System.Drawing.Point(3, 130);
            this.btnProductosMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductosMenuPrincipal.Name = "btnProductosMenuPrincipal";
            this.btnProductosMenuPrincipal.Size = new System.Drawing.Size(147, 47);
            this.btnProductosMenuPrincipal.TabIndex = 3;
            this.btnProductosMenuPrincipal.Text = "Productos";
            this.btnProductosMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnProductosMenuPrincipal.Click += new System.EventHandler(this.BtnProductosMenuPrincipal_Click);
            // 
            // btnRegresarMenuPrincipal
            // 
            this.btnRegresarMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal.Location = new System.Drawing.Point(157, 253);
            this.btnRegresarMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresarMenuPrincipal.Name = "btnRegresarMenuPrincipal";
            this.btnRegresarMenuPrincipal.Size = new System.Drawing.Size(147, 39);
            this.btnRegresarMenuPrincipal.TabIndex = 4;
            this.btnRegresarMenuPrincipal.Text = "Regresar";
            this.btnRegresarMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal.Click += new System.EventHandler(this.BtnRegresarMenuPrincipal_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 320);
            this.Controls.Add(this.btnRegresarMenuPrincipal);
            this.Controls.Add(this.btnProductosMenuPrincipal);
            this.Controls.Add(this.btnFacturacionMenuPrincipal);
            this.Controls.Add(this.btnServiciosMenuPrincipal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServiciosMenuPrincipal;
        private System.Windows.Forms.Button btnFacturacionMenuPrincipal;
        private System.Windows.Forms.Button btnProductosMenuPrincipal;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal;
    }
}