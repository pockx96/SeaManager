namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class BitacoraView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.DatagridBitacora = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxSearch = new CustomControls.RJControls.RJTextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.White;
            this.BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearch.IconSize = 30;
            this.BtnSearch.Location = new System.Drawing.Point(505, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(35, 34);
            this.BtnSearch.TabIndex = 28;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // DatagridBitacora
            // 
            this.DatagridBitacora.AllowUserToAddRows = false;
            this.DatagridBitacora.AllowUserToResizeColumns = false;
            this.DatagridBitacora.AllowUserToResizeRows = false;
            this.DatagridBitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DatagridBitacora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DatagridBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Presentación,
            this.Cantidad,
            this.Kilos});
            this.DatagridBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridBitacora.EnableHeadersVisualStyles = false;
            this.DatagridBitacora.Location = new System.Drawing.Point(128, 89);
            this.DatagridBitacora.Name = "DatagridBitacora";
            this.DatagridBitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridBitacora.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridBitacora.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridBitacora.RowTemplate.Height = 34;
            this.DatagridBitacora.Size = new System.Drawing.Size(460, 283);
            this.DatagridBitacora.TabIndex = 27;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Prosedimiento";
            this.Producto.Name = "Producto";
            this.Producto.Width = 130;
            // 
            // Presentación
            // 
            this.Presentación.HeaderText = "Usuario";
            this.Presentación.Name = "Presentación";
            this.Presentación.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Proveedor";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Kilos
            // 
            this.Kilos.HeaderText = "Fecha";
            this.Kilos.Name = "Kilos";
            this.Kilos.Width = 85;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxSearch.BorderRadius = 0;
            this.TxtBoxSearch.BorderSize = 2;
            this.TxtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxSearch.Location = new System.Drawing.Point(159, 24);
            this.TxtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxSearch.Multiline = false;
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxSearch.PasswordChar = false;
            this.TxtBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxSearch.PlaceholderText = "";
            this.TxtBoxSearch.Size = new System.Drawing.Size(339, 31);
            this.TxtBoxSearch.TabIndex = 23;
            this.TxtBoxSearch.Texts = "";
            this.TxtBoxSearch.UnderlinedStyle = false;
            this.TxtBoxSearch._TextChanged += new System.EventHandler(this.TxtBoxSearch__TextChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(11, 449);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(103, 36);
            this.iconButton3.TabIndex = 39;
            this.iconButton3.Text = "Excel";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BitacoraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DatagridBitacora);
            this.Controls.Add(this.BtnSearch);
            this.Name = "BitacoraView";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJTextBox TxtBoxSearch;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private System.Windows.Forms.DataGridView DatagridBitacora;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
    }
}
