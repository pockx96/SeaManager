namespace MarDeCortezDsk.UserControlls
{
    partial class ListaFolios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatagridFolios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.calcular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.LblPendientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFinalizados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFolios)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridFolios
            // 
            this.DatagridFolios.AllowUserToAddRows = false;
            this.DatagridFolios.AllowUserToDeleteRows = false;
            this.DatagridFolios.AllowUserToResizeColumns = false;
            this.DatagridFolios.AllowUserToResizeRows = false;
            this.DatagridFolios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DatagridFolios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DatagridFolios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridFolios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridFolios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DatagridFolios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.borrar,
            this.calcular});
            this.DatagridFolios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridFolios.DefaultCellStyle = dataGridViewCellStyle10;
            this.DatagridFolios.EnableHeadersVisualStyles = false;
            this.DatagridFolios.Location = new System.Drawing.Point(44, 114);
            this.DatagridFolios.Name = "DatagridFolios";
            this.DatagridFolios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridFolios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DatagridFolios.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridFolios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DatagridFolios.RowTemplate.Height = 34;
            this.DatagridFolios.Size = new System.Drawing.Size(633, 340);
            this.DatagridFolios.TabIndex = 31;
            this.DatagridFolios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridFolios_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Folio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Proveedor";
            this.Column2.Name = "Column2";
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Maquilador";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // borrar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = "Borrar";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            this.borrar.DefaultCellStyle = dataGridViewCellStyle8;
            this.borrar.HeaderText = "";
            this.borrar.Name = "borrar";
            // 
            // calcular
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "Calcular";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            this.calcular.DefaultCellStyle = dataGridViewCellStyle9;
            this.calcular.HeaderText = "";
            this.calcular.Name = "calcular";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.Location = new System.Drawing.Point(32, 2);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(319, 62);
            this.TitleBar.TabIndex = 34;
            this.TitleBar.Text = "Folios Pendientes";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // LblPendientes
            // 
            this.LblPendientes.AutoSize = true;
            this.LblPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.LblPendientes.Location = new System.Drawing.Point(572, 20);
            this.LblPendientes.Name = "LblPendientes";
            this.LblPendientes.Size = new System.Drawing.Size(105, 24);
            this.LblPendientes.TabIndex = 35;
            this.LblPendientes.Text = "Pendientes";
            this.LblPendientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(694, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 22);
            this.panel1.TabIndex = 36;
            // 
            // LblFinalizados
            // 
            this.LblFinalizados.AutoSize = true;
            this.LblFinalizados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFinalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinalizados.ForeColor = System.Drawing.Color.White;
            this.LblFinalizados.Location = new System.Drawing.Point(706, 22);
            this.LblFinalizados.Name = "LblFinalizados";
            this.LblFinalizados.Size = new System.Drawing.Size(105, 24);
            this.LblFinalizados.TabIndex = 37;
            this.LblFinalizados.Text = "Finalizados";
            this.LblFinalizados.Click += new System.EventHandler(this.LblFinalizados_Click);
            // 
            // ListaFolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.LblFinalizados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblPendientes);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.DatagridFolios);
            this.Name = "ListaFolios";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.ListaFolios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFolios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagridFolios;
        private FontAwesome.Sharp.IconButton TitleBar;
        private System.Windows.Forms.Label LblPendientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.DataGridViewButtonColumn calcular;
    }
}
