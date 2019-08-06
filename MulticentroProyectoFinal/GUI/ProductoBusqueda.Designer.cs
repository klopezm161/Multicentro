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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProductoBusqueda = new System.Windows.Forms.Button();
            this.btnMenuPrincipalProductoBusqueda = new System.Windows.Forms.Button();
            this.CBoxCategoriaProductoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtCodigoProductoBusqueda = new System.Windows.Forms.TextBox();
            this.txtNombreProductoBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÚSQUEDA PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // btnBuscarProductoBusqueda
            // 
            this.btnBuscarProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoBusqueda.Location = new System.Drawing.Point(482, 227);
            this.btnBuscarProductoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProductoBusqueda.Name = "btnBuscarProductoBusqueda";
            this.btnBuscarProductoBusqueda.Size = new System.Drawing.Size(193, 34);
            this.btnBuscarProductoBusqueda.TabIndex = 4;
            this.btnBuscarProductoBusqueda.Text = "Buscar";
            this.btnBuscarProductoBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarProductoBusqueda.Click += new System.EventHandler(this.BtnBuscarProductoBusqueda_Click);
            // 
            // btnMenuPrincipalProductoBusqueda
            // 
            this.btnMenuPrincipalProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipalProductoBusqueda.Location = new System.Drawing.Point(24, 227);
            this.btnMenuPrincipalProductoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuPrincipalProductoBusqueda.Name = "btnMenuPrincipalProductoBusqueda";
            this.btnMenuPrincipalProductoBusqueda.Size = new System.Drawing.Size(193, 34);
            this.btnMenuPrincipalProductoBusqueda.TabIndex = 6;
            this.btnMenuPrincipalProductoBusqueda.Text = "Menú Principal";
            this.btnMenuPrincipalProductoBusqueda.UseVisualStyleBackColor = true;
            this.btnMenuPrincipalProductoBusqueda.Click += new System.EventHandler(this.BtnMenuPrincipalProductoBusqueda_Click);
            // 
            // CBoxCategoriaProductoBusqueda
            // 
            this.CBoxCategoriaProductoBusqueda.FormattingEnabled = true;
            this.CBoxCategoriaProductoBusqueda.Location = new System.Drawing.Point(175, 98);
            this.CBoxCategoriaProductoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBoxCategoriaProductoBusqueda.Name = "CBoxCategoriaProductoBusqueda";
            this.CBoxCategoriaProductoBusqueda.Size = new System.Drawing.Size(495, 24);
            this.CBoxCategoriaProductoBusqueda.TabIndex = 7;
            // 
            // txtCodigoProductoBusqueda
            // 
            this.txtCodigoProductoBusqueda.Location = new System.Drawing.Point(175, 148);
            this.txtCodigoProductoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProductoBusqueda.Name = "txtCodigoProductoBusqueda";
            this.txtCodigoProductoBusqueda.Size = new System.Drawing.Size(495, 22);
            this.txtCodigoProductoBusqueda.TabIndex = 8;
            // 
            // txtNombreProductoBusqueda
            // 
            this.txtNombreProductoBusqueda.Location = new System.Drawing.Point(175, 197);
            this.txtNombreProductoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProductoBusqueda.Name = "txtNombreProductoBusqueda";
            this.txtNombreProductoBusqueda.Size = new System.Drawing.Size(495, 22);
            this.txtNombreProductoBusqueda.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(647, 308);
            this.dataGridView1.TabIndex = 10;
            // 
            // ProductoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreProductoBusqueda);
            this.Controls.Add(this.txtCodigoProductoBusqueda);
            this.Controls.Add(this.CBoxCategoriaProductoBusqueda);
            this.Controls.Add(this.btnMenuPrincipalProductoBusqueda);
            this.Controls.Add(this.btnBuscarProductoBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductoBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoBusqueda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductoBusqueda_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarProductoBusqueda;
        private System.Windows.Forms.Button btnMenuPrincipalProductoBusqueda;
        private System.Windows.Forms.ComboBox CBoxCategoriaProductoBusqueda;
        private System.Windows.Forms.TextBox txtCodigoProductoBusqueda;
        private System.Windows.Forms.TextBox txtNombreProductoBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}