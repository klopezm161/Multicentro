namespace MulticentroProyectoFinal
{
    partial class ProductoBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBusqueda));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProductoBusqueda = new System.Windows.Forms.Button();
            this.btnMenuPrincipalProductoBusqueda = new System.Windows.Forms.Button();
            this.txtCodigoProductoBusqueda = new System.Windows.Forms.TextBox();
            this.txtNombreProductoBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÚSQUEDA PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // btnBuscarProductoBusqueda
            // 
            this.btnBuscarProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoBusqueda.Location = new System.Drawing.Point(357, 168);
            this.btnBuscarProductoBusqueda.Name = "btnBuscarProductoBusqueda";
            this.btnBuscarProductoBusqueda.Size = new System.Drawing.Size(145, 28);
            this.btnBuscarProductoBusqueda.TabIndex = 4;
            this.btnBuscarProductoBusqueda.Text = "Buscar";
            this.btnBuscarProductoBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarProductoBusqueda.Click += new System.EventHandler(this.BtnBuscarProductoBusqueda_Click);
            // 
            // btnMenuPrincipalProductoBusqueda
            // 
            this.btnMenuPrincipalProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalProductoBusqueda.Location = new System.Drawing.Point(17, 168);
            this.btnMenuPrincipalProductoBusqueda.Name = "btnMenuPrincipalProductoBusqueda";
            this.btnMenuPrincipalProductoBusqueda.Size = new System.Drawing.Size(145, 28);
            this.btnMenuPrincipalProductoBusqueda.TabIndex = 6;
            this.btnMenuPrincipalProductoBusqueda.Text = "Menú Principal";
            this.btnMenuPrincipalProductoBusqueda.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalProductoBusqueda.Click += new System.EventHandler(this.BtnMenuPrincipalProductoBusqueda_Click);
            // 
            // txtCodigoProductoBusqueda
            // 
            this.txtCodigoProductoBusqueda.Location = new System.Drawing.Point(130, 101);
            this.txtCodigoProductoBusqueda.Name = "txtCodigoProductoBusqueda";
            this.txtCodigoProductoBusqueda.Size = new System.Drawing.Size(372, 20);
            this.txtCodigoProductoBusqueda.TabIndex = 8;
            // 
            // txtNombreProductoBusqueda
            // 
            this.txtNombreProductoBusqueda.Location = new System.Drawing.Point(130, 133);
            this.txtNombreProductoBusqueda.Name = "txtNombreProductoBusqueda";
            this.txtNombreProductoBusqueda.Size = new System.Drawing.Size(372, 20);
            this.txtNombreProductoBusqueda.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(485, 230);
            this.dataGridView1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ProductoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreProductoBusqueda);
            this.Controls.Add(this.txtCodigoProductoBusqueda);
            this.Controls.Add(this.btnMenuPrincipalProductoBusqueda);
            this.Controls.Add(this.btnBuscarProductoBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ProductoBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoBusqueda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductoBusqueda_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarProductoBusqueda;
        private System.Windows.Forms.Button btnMenuPrincipalProductoBusqueda;
        private System.Windows.Forms.TextBox txtCodigoProductoBusqueda;
        private System.Windows.Forms.TextBox txtNombreProductoBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}